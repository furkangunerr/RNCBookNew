using System;
using System.Collections.Generic;
using System.Text;

namespace RNCBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICompanyRepository Company { get; }
        ICoverTypeRepository CoverType { get;}
        IApplicationUserRepository ApplicationUser { get; }
        IProductRepository Product { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
