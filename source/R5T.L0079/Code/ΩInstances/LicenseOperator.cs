using System;


namespace R5T.L0079
{
    public class LicenseOperator : ILicenseOperator
    {
        #region Infrastructure

        public static ILicenseOperator Instance { get; } = new LicenseOperator();


        private LicenseOperator()
        {
        }

        #endregion
    }
}
