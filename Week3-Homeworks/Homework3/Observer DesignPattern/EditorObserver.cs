﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_DesignPattern
{
    public class EditorObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Check the curent version of the post!!!!");
        }
    }
}
