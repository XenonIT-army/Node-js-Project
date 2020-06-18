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
using WebApplication3.TaskService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {

        //IKernel kernel = new StandardKernel(new TaskNinjectModule());
        public IService<InformationDto> informationService;
        private ObservableCollection<InformationDto> Informations = new ObservableCollection<InformationDto>();

        public TaskController(IService<InformationDto> informationService)
        {
            this.informationService = informationService;
            Informations = informationService.GetAll().ToObservableCollection();
        }

        // GET: api/<controller>
        [HttpGet]
        public ObservableCollection<InformationDto> Get()
        {
            return Informations;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
