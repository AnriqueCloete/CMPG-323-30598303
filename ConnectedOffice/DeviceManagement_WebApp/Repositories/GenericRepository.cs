using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //This class contains the implementation of the methods in the IGenericRepository interface class
        //This is the only place where the DBContext is accessed directly, in order to promote loose coupling of code
        //This class inherits from the IgenericRepository interface class
        protected readonly ConnectedOfficeContext _context;

        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }

        public void Remove(T entity)
        {
            _context.Device
                 .Include(d => d.Category)
                 .Include(d => d.Zone);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
           
            return _context.Set<T>().ToList();
        }

        public T GetById(Guid? id)
        {
            return _context.Set<T>().Find(id);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public bool CatExists(Guid id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }

        public bool ZneExists(Guid id)
        {
            return _context.Zone.Any(e => e.ZoneId == id);
        }

        public bool DevExists(Guid id)
        {
            return _context.Device.Any(e => e.DeviceId == id);
        }


       

    }
}
