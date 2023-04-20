using SkateboardsProject.Data.Model;
using SkateboardsProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Business.EntityesController
{
    public class WheelsController : IController<Wheel>
    {

        private SkateboardsContext Context = new SkateboardsContext();
        public void Add(Wheel wheel)
        {
            using (Context = new SkateboardsContext())
            {
                Context.Wheels.ToList();
                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Context = new SkateboardsContext())
            {
                var wheel = Context.Wheels.Find(id);
                if (wheel != null)
                {
                    Context.Wheels.Remove(wheel);
                    Context.SaveChanges();
                }
            }
        }

        public void Get(int id)
        {
            using (Context = new SkateboardsContext())
            {
                Context.Wheels.Find(id);
            }
        }

        public List<Wheel> GetAll()
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Wheels.ToList();
            }
        }

        public void Update(Wheel wheel)
        {
            using (Context = new SkateboardsContext())
            {
                var item = Context.Decks.Find(wheel.Id);
                if (item != null)
                {
                    Context.Entry(item).CurrentValues.SetValues(wheel);
                    Context.SaveChanges();
                }
            }
        }
    }
}
