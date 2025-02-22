﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        //This interface class contains all methods used throught all controllers
        //the implementation of these methods are contained in the GenericRepository class
        T GetById(Guid? id);

        IEnumerable<T> GetAll();
        
        void Update(T entity);

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        bool CatExists(Guid id);

        bool ZneExists(Guid id);

        bool DevExists(Guid id);

       
    }
}
