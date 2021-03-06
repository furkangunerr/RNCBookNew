﻿using RNCBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RNCBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepositoryAsync<Category>
    {
        void Update(Category category);
    }
}
