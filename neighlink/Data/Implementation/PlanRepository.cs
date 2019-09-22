using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Data.Implementation
{
    public class PlanRepository : BaseRepository, IPlanRepository
    {
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
            context.Plans.Add(t);
            context.SaveChanges();
            return true;
        }

        public bool Update(Plan t)
        {
            throw new NotImplementedException();
        }
    }
}
