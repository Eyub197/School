using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




    public class BearingController : ITableController<Bearing>
    {
        private readonly SkateboardContext context;

      

        public IEnumerable<Bearing> GetAll()
        {
            return context.Bearings.ToList();
        }

        public Bearing GetById(int id)
        {
            return context.Bearings.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Bearing entity)
        {
            context.Bearings.Add(entity);
            context.SaveChanges();
        }

        public void Update(int id, Bearing entity)
        {
            var bearingToUpdate = context.Bearings.FirstOrDefault(x => x.Id == id);
            if (bearingToUpdate != null)
            {
                bearingToUpdate.Id = entity.Id;
                bearingToUpdate.Name = entity.Name;
                bearingToUpdate.AbecRating = entity.AbecRating;
                bearingToUpdate.BearingMaterial = entity.BearingMaterial;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var bearingToDelete = context.Bearings.FirstOrDefault(x => x.Id == id);
            if (bearingToDelete != null)
            {
                context.Bearings.Remove(bearingToDelete);
                context.SaveChanges();
            }
        }
    }

