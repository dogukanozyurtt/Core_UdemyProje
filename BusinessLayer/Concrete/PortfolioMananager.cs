﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioMananager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioMananager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio t)
        {
          _portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
          _portfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
          return _portfolioDal.GetByID(id); 
        }

        public List<Portfolio> TGetList()
        {
           return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
           _portfolioDal.Update(t);
        }
    }
}
