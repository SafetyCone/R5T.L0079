using System;

using R5T.T0142;


namespace R5T.L0079
{
    [DataTypeMarker]
    public class RepositorySpecification
    {
        public string Organization { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsPrivate { get; set; }
        public License License { get; set; }
    }
}
