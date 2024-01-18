using System;


namespace R5T.L0079
{
    public class LicenseTemplates : ILicenseTemplates
    {
        #region Infrastructure

        public static ILicenseTemplates Instance { get; } = new LicenseTemplates();


        private LicenseTemplates()
        {
        }

        #endregion
    }
}
