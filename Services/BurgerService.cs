using BurgerRestaurant.Models;
using BurgerRestaurant.Data;

namespace BurgerRestaurant.Services
{
    public class BurgerService
    {
        private readonly BurgerContext _context = default!;

        public BurgerService(BurgerContext context)
        {
            _context = context;
        }

        public IList<Burger> GetBurgers()
        {
            if (_context.Burgers != null)
            {
                return _context.Burgers.ToList();
            }
            return new List<Burger>();
        }
        public void AddBurger(Burger burger)
        {
            if (_context.Burgers != null)
            {
                _context.Burgers.Add(burger);
                _context.SaveChanges();
            }
        }
        public void DeleteBurger(int id)
        {
            if (_context.Burgers != null)
            {
                var burger = _context.Burgers.Find(id);
                if (burger != null)
                {
                    _context.Burgers.Remove(burger);
                    _context.SaveChanges();
                }
            }
        }
    }
}