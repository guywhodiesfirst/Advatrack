namespace Data.Interfaces;

public interface IDeleteRepository
{
    Task<bool> DeleteByIdAsync(Guid id);
}