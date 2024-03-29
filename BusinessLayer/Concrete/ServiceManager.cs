﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IGenericService<Service>
    {

        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            this._serviceDal = serviceDal;
        }

        public void TAdd(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TRemove(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
