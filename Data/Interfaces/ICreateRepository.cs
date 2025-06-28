namespace Data.Interfaces;

public interface ICreateRepository<T>
{
    Task AddAsync(T entity);
}