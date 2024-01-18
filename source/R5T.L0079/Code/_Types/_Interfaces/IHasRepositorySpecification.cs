using System;

using R5T.T0142;


namespace R5T.L0079
{
    [DataTypeMarker]
    public interface IHasRepositorySpecification
    {
        RepositorySpecification RepositorySpecification { get; }
    }
}
