﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.InMemoryModel
{
    internal interface IModelChangeObserver
    {
        void ApplyUpdateModel();
    }
}
