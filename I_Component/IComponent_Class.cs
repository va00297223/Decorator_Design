﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design.I_Component
{
    public interface IComponent<T>
    {
        T GetText();
    }
}
