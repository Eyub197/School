﻿using System;
using System.Collections.Generic;
using System.Text;


    public interface ITableController<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }

