using System;

using R5T.T0142;


namespace R5T.L0079
{
    [DataTypeMarker]
    public interface IWithRepositorySpecification :
        IHasRepositorySpecification
    {
        new RepositorySpecification RepositorySpecification { get; set; }
    }
}
