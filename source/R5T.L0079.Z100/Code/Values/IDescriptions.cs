using System;

using R5T.T0131;


namespace R5T.L0079.Z100
{
    /// <summary>
    /// Example repository descriptions.
    /// </summary>
    [ValuesMarker]
    public partial interface IDescriptions : IValuesMarker
    {
        public string ForTesting => "Example GitHub repository for testing.";
    }
}
