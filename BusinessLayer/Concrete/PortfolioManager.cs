using EntityLayer.Concrete;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IGenericService<Portfolio>
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            this._portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio entity)
        {
            _portfolioDal.Insert(entity);
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TRemove(Portfolio entity)
        {
            _portfolioDal.Delete(entity);
        }

        public void TUpdate(Portfolio entity)
        {
            _portfolioDal.Update(entity);
        }
    }
}
