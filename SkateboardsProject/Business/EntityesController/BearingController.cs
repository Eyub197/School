using SkateboardsProject.Data.Model;
using SkateboardsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkateboardsProject.Business.EntityesController
{
    class BearingController : IController<Bearing>
    {
        private SkateboardsContext Context = new SkateboardsContext();
        public void Add(Bearing bearing)
        {
            using (Context = new SkateboardsContext())
            {
                Context.Bearings.ToList();
                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bearing> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Bearing item)
        {
            throw new NotImplementedException();
        }
    }
}
