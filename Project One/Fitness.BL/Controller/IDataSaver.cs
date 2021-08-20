﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Controller
{
    public interface IDataSaver<T> where T : class
    {
        void Save(T item);
        T Load();
    }
}
