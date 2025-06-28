using Data.Entities;

namespace Data.Interfaces;

public interface IWorkspaceRepository :
    IReadRepository<Workspace>,
    ICreateRepository<Workspace>,
    IUpdateRepository<Workspace>,
    IDeleteRepository
{
    
}