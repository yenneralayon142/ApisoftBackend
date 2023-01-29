using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts;


namespace Repository.Configuration
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    { 
    
        AppDbContext _context;
        public RepositoryBase(AppDbContext context) => _context = context;

        public IQueryable<T> FindAll(bool trackChanges)
        {
        return _context.Set<T>().AsTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            if (!trackChanges)
            {
                return _context.Set<T>().Where(expression).AsNoTracking();
            }

            return _context.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }



    }
}



