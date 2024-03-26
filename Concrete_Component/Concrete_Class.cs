using Decorator_Design.I_Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design.Concrete_Component
{
    public class Concrete_Class : IComponent<string>
    {
        public string GetText()
        {
            return "Myself Vishwa Virani.! I'm Studing Mobile Appliction Course in Cambrian College.";
        }
    }
}
