using System;

using R5T.T0240;


namespace R5T.L0079
{
    [WithXMarker]
    public interface IWithRepositorySpecification : IWithXMarker,
        IHasRepositorySpecification
    {
        new RepositorySpecification RepositorySpecification { get; set; }
    }
}
