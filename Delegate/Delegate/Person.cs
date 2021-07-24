﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler GoWork;
        public string Name { get; set; }
        
        public void TakeTime(DateTime now)
        {
            if(now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                //var args = new EventArgs();
                GoWork?.Invoke(this, null/*args*/);
            }

        }
    }
}
