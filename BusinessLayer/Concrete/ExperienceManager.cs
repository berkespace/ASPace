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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience entity)
        {
            throw new NotImplementedException();
        }

        public Experience TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetList()
        {
           return _experienceDal.GetList();
        }

        public void TRemove(Experience entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience entity)
        {
            throw new NotImplementedException();
        }
    }
}
