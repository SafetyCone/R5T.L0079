using System;


namespace R5T.L0079
{
    public static class Instances
    {
        public static L0066.IContextOperator ContextOperator => L0066.ContextOperator.Instance;
        public static L0078.F001.IGitHubClientOperator GitHubClientOperator => L0078.F001.GitHubClientOperator.Instance;
        public static IGitHubOperator GitHubOperator => L0079.GitHubOperator.Instance;
        public static ILicenseTemplates LicenseTemplates => L0079.LicenseTemplates.Instance;
        public static ILicenseOperator LicenseOperator => L0079.LicenseOperator.Instance;
        public static L0066.ISwitchOperator SwitchOperator => L0066.SwitchOperator.Instance;
    }
}