
using JayBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        void Update(Category category);
    }
}
