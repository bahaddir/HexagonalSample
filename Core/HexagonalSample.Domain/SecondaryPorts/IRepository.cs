using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalSample.Domain.SecondaryPorts
{
    public interface IRepository<T> where T:class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);


        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
