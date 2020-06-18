using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Create(TEntity entity);
        void AddOrUpdate(TEntity dto);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
