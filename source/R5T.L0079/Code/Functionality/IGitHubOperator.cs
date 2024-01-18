using System;
using System.Threading.Tasks;

using Octokit;

using R5T.T0132;


namespace R5T.L0079
{
    [FunctionalityMarker]
    public partial interface IGitHubOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Creates a repository, but will fail if the repository already exists (non-idempotent in that it does not check if the repository already exists before calling a non-idempotent operation).
        /// </summary>
        /// <exception cref="RepositoryExistsException">Thron if the repository identified by organization\name already exists.</exception>
        public async Task<Repository> Create_Repository_NonIdempotent(
            GitHubClient gitHubClient,
            RepositorySpecification repositorySpecification)
        {
            var licenseTemplate = Instances.LicenseOperator.Get_LicenseTemplate(
                repositorySpecification.License);

            var newRepository = new NewRepository(repositorySpecification.Name)
            {
                // Always initialize with an empty README.txt in the first commit.
                AutoInit = true,
                Description = repositorySpecification.Description,
                LicenseTemplate = licenseTemplate,
                Private = repositorySpecification.IsPrivate
            };

            // Code can only create repositories for the organizations values of 1) the current user, and 2) an organization for which the current user is authorized to create repositories.
            var currentUser = await gitHubClient.User.Current();

            // When creating a repository for the current user, the organization cannot be specified.
            var creatingForCurrentUser = currentUser.Login == repositorySpecification.Organization;

            var createdRepository = creatingForCurrentUser
                ? await gitHubClient.Repository.Create(
                    newRepository)
                : await gitHubClient.Repository.Create(
                    repositorySpecification.Organization,
                    newRepository);

            // Wait a few seconds for the repository to be fully created on GitHub's side. This allows any following operations that request the repository to succeed.
            await Task.Delay(3000);

            return createdRepository;
        }

        public async Task Delete_Repository(
            GitHubClient gitHubClient,
            Repository repository)
        {
            await gitHubClient.Repository.Delete(repository.Id);
        }
    }
}
