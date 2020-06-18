using BLL.Dto;
using BLL.IService;
using BLL.Service;
using DAL.Context;
using DAL.Interface;
using DAL.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Moduls
{
    public class TaskNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<TaskInfo>>().To<InformationRepository>();
            Bind<IService<InformationDto>>().To<InformationService>();
            Bind<DbContext>().To<DataContext>();
        }
    }
}
