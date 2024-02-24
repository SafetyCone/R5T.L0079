using System;

using R5T.T0240;


namespace R5T.L0079
{
    [HasXMarker]
    public interface IHasRepositorySpecification : IHasXMarker
    {
        RepositorySpecification RepositorySpecification { get; }
    }
}
