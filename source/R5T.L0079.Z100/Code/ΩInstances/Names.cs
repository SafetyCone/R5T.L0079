using System;


namespace R5T.L0079.Z100
{
    public class Names : INames
    {
        #region Infrastructure

        public static INames Instance { get; } = new Names();


        private Names()
        {
        }

        #endregion
    }
}


namespace R5T.L0079.Z100.Raw
{
    public class Names : INames
    {
        #region Infrastructure

        public static INames Instance { get; } = new Names();


        private Names()
        {
        }

        #endregion
    }
}
