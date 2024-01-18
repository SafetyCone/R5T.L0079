using System;


namespace R5T.L0079
{
    public class GitHubOperator : IGitHubOperator
    {
        #region Infrastructure

        public static IGitHubOperator Instance { get; } = new GitHubOperator();


        private GitHubOperator()
        {
        }

        #endregion
    }
}
