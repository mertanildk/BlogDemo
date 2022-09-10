﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWriterService
    {
        void Add(Writer writer);
        void Delete(Writer writer);
        void Update(Writer writer);
        Writer GetById(int id);
        List<Writer> GetAll();
    }
}
