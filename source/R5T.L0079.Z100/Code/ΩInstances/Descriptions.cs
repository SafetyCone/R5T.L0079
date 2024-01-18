using System;


namespace R5T.L0079.Z100
{
    public class Descriptions : IDescriptions
    {
        #region Infrastructure

        public static IDescriptions Instance { get; } = new Descriptions();


        private Descriptions()
        {
        }

        #endregion
    }
}
