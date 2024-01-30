using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

using R5T.L0078.T000;
using R5T.T0131;


namespace R5T.L0079
{
    [ValuesMarker]
    public partial interface IGitHubClientContextOperations : IValuesMarker
    {
        public Func<TContext, Task> Create_Repository_Unchecked<TContext>(
            RepositorySpecification repositorySpecification)
            where TContext : IHasGitHubClient
        {
            return context =>
            {
                return Instances.GitHubOperator.Create_Repository_NonIdempotent(
                    context.GitHubClient,
                    repositorySpecification);
            };
        }

        public Task Create_Repository_Unchecked<TContext>(TContext context)
            where TContext : IHasGitHubClient, IHasRepositorySpecification
        {
            return Instances.ContextOperator.In_Context(
                context,
                this.Create_Repository_Unchecked<TContext>(
                    context.RepositorySpecification));
        }

        public async Task Create_Repository<TContext>(TContext context)
            where TContext : IHasGitHubClient, IHasRepositorySpecification, IWithRepository
        {
            context.Repository = await Instances.GitHubOperator.Create_Repository_NonIdempotent(
                context.GitHubClient,
                context.RepositorySpecification);
        }

        [Obsolete("See R5T.L0081.O002.IGitHubClientContextOperations.Delete_Repository()")]
        public async Task Delete_Repository<TContext>(TContext context)
            where TContext : IHasGitHubClient, IHasRepository
        {
            await Instances.GitHubClientOperator.Delete_Repository_NonIdempotent(
                context.GitHubClient,
                context.Repository);
        }
    }
}
