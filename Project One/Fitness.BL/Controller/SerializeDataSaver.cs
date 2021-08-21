﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Controller
{
    class SerializeDataSaver<T> : IDataSaver<T> where T : class
    {
        public List<T> Load()
        {
            var formatter = new BinaryFormatter();
            var fileName = typeof(T) + ".dat";
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is List<T> items)
                {
                    return items;

                }
                else
                {
                    return new List<T>();
                }
            }
        }
        public void Save(T item)
        {
            var formatter = new BinaryFormatter();
            var fileName = typeof(T) + ".dat";
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }
    }
}
