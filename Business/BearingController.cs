﻿using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class BearingController:IController<Bearing>
    {
        private SkateboardsContext Context = new SkateboardsContext();

        public void Add(Bearing bearing)
        {
            using (Context = new SkateboardsContext())
            {
                Context.Bearings.Add(bearing);
                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Context = new SkateboardsContext())
            {
                var bearing = Context.Bearings.Find(id);
                if (bearing != null)
                {
                    Context.Bearings.Remove(bearing);
                    Context.SaveChanges();
                }
            }
        }

        public Bearing Get(int id)
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Bearings.Find(id);
            }
        }

        public List<Bearing> GetAll()
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Bearings.ToList();
            }
        }

        public void Update(Bearing bearing)
        {
            using (Context = new SkateboardsContext())
            {
                var item = Context.Bearings.Find(bearing.Id);
                if (item != null)
                {
                    Context.Entry(item).CurrentValues.SetValues(bearing);
                    Context.SaveChanges();
                }
            }
        }
    }
}
