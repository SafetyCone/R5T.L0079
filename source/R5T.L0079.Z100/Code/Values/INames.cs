using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.L0079.Z100
{
    /// <summary>
    /// Example repository names.
    /// </summary>
    [ValuesMarker]
    public partial interface INames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.INames _Raw => Raw.Names.Instance;

#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <para><inheritdoc cref="Raw.INames.E2000" path="/descendant::value"/> - NOTE: this repository could be deleted at any time!</para>
        /// A disposable repository name that can be used during testing.
        /// Do not put anything important into it.
        /// </summary>
        public string Disposable => _Raw.E2000;
    }
}
