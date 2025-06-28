namespace Data.Interfaces;

public interface IUpdateRepository<T>
{
    Task<bool> UpdateAsync(T entity);
}