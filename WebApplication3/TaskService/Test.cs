using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using BLL.Dto;
using BLL.IService;
using BLL.Moduls;
using Microsoft.AspNetCore.Mvc;
using Ninject;
using WebApplication3.Extension;

namespace WebApplication3.TaskService
{
    //public class Test
    //{
    //    IKernel kernel = new StandardKernel(new TaskNinjectModule());
    //    public IService<InformationDto> informationService;
    //    private ObservableCollection<InformationDto> Informations = new ObservableCollection<InformationDto>();

    //    public Test(IService<InformationDto> informationService)
    //    {
    //        kernel.
    //        this.informationService = informationService;
    //        Informations = informationService.GetAll().ToObservableCollection();
    //    }
    //}
}
