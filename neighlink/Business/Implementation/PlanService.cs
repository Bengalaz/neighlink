using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Implementation;
using Entity;

namespace Business.Implementation
{
    public class PlanService : IPlanService
    {
        private IPlanRepository planRepository = new PlanRepository();
        public bool Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Plan> FindAll()
        {
            throw new NotImplementedException();
        }

        public Plan FindById(int? id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Plan t)
        {
            return planRepository.Insert(t);
        }

        public bool Update(Plan t)
        {
            throw new NotImplementedException();
        }
    }
}
