using DAL.Abstruction;
using DAL.Context;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class TaskUnitOfWork : BaseUnitOfWork
    {
        public IRepository<TaskInfo> InformationRepository { get; }

        public TaskUnitOfWork(DbContext db,
                                 IRepository<TaskInfo> informationRepository) : base(db)
        {
            this.InformationRepository = informationRepository;
        }

    }
}
