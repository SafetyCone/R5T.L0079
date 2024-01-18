using System;

using R5T.T0132;


namespace R5T.L0079
{
    [FunctionalityMarker]
    public partial interface ILicenseOperator : IFunctionalityMarker
    {
        public string Get_LicenseTemplate(License license)
        {
            var output = license switch
            {
                License.MIT => Instances.LicenseTemplates.MIT,
                _ => throw Instances.SwitchOperator.Get_UnexpectedEnumerationValueException(license)
            };

            return output;
        }
    }
}
