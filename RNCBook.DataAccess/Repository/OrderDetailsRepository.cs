using RNCBook.DataAccess.Data;
using RNCBook.DataAccess.Repository.IRepository;
using RNCBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNCBook.DataAccess.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetails obj)
        {
            _db.Update(obj);
        }
    }
}
