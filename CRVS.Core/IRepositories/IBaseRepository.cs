using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int id);
        Task<IEnumerable<T>> GetAllAsync();
        void Add(T model);
        void UpdateData (int id , T model);
        void Delete(int id);
        void SaveChanges();

    }
}
