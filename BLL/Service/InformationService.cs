using AutoMapper;
using BLL.Dto;
using BLL.IService;
using DAL.Context;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    class InformationService : IService<InformationDto>
    {

        private TaskUnitOfWork uow;
        IMapper mapper;


        public InformationService(TaskUnitOfWork uow)
        {
            this.uow = uow;
            var config = new MapperConfiguration(cfg =>
            {
                cfg
                .CreateMap<TaskInfo, InformationDto>()
                .ReverseMap();
            });
            mapper = config.CreateMapper();
        }

        public void AddOrUpdate(InformationDto dto)
        {
            var entity = mapper.Map<TaskInfo>(dto);
            uow.InformationRepository.AddOrUpdate(entity);
        }


        public InformationDto Create(InformationDto dto)
        {
            var entity = mapper.Map<TaskInfo>(dto);
            var newEntity = uow.InformationRepository.Create(entity);
            return mapper.Map<InformationDto>(newEntity);
        }

        public void Delete(InformationDto dto)
        {
            var entity = uow.InformationRepository.Get(dto.Id);
            uow.InformationRepository.Delete(entity);
        }

        public InformationDto Get(int id)
        {
            var entity = uow.InformationRepository.Get(id);
            return mapper.Map<InformationDto>(entity);
        }

        public IEnumerable<InformationDto> GetAll()
        {
            var res = uow.InformationRepository
                 .GetAll()
                 .ToList()
                 .Select(entity => mapper.Map<InformationDto>(entity));
            return res;
        }

        public void Save()
        {
            uow.InformationRepository.Save();
            uow.Save();
        }

        public void Update(InformationDto dto)
        {
            var entity = mapper.Map<TaskInfo>(dto);
            uow.InformationRepository.Update(entity);
        }
    }
}
