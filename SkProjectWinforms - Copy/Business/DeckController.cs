using Model;
using Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class DeckController:IController<Deck>
    {
        private SkateboardsContext Context = new SkateboardsContext();

        public void Add(Deck deck)
        {
            using (Context = new SkateboardsContext())
            {
                Context.Decks.Add(deck);
                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (Context = new SkateboardsContext())
            {
                var deck = Context.Decks.Find(id);
                if (deck != null)
                {
                    Context.Decks.Remove(deck);
                    Context.SaveChanges();
                }
            }
        }

        public Deck Get(int id)
        {
            using (var context = new SkateboardsContext())
            {
                return context.Decks.Find(id);
            }
        }

        public List<Deck> GetAll()
        {
            using (Context = new SkateboardsContext())
            {
                return Context.Decks.ToList();
            }
        }

        public void Update(Deck deck)
        {
            using (Context = new SkateboardsContext())
            {
                var item = Context.Decks.Find(deck.Id);
                if (item != null)
                {
                    Context.Entry(item).CurrentValues.SetValues(deck);
                    Context.SaveChanges();
                }
            }
        }
    }
}
