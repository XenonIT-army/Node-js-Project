using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IService
{
    public interface IService<TEntityDto>
    {
        IEnumerable<TEntityDto> GetAll();
        TEntityDto Get(int id);
        TEntityDto Create(TEntityDto dto);
        void AddOrUpdate(TEntityDto dto);
        void Update(TEntityDto dto);
        void Delete(TEntityDto dto);
        void Save();
    }
}
