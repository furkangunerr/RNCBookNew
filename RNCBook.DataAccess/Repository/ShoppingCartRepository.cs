using RNCBook.DataAccess.Data;
using RNCBook.DataAccess.Repository.IRepository;
using RNCBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNCBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);
        }
    }
}
