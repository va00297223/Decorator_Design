using Decorator_Design.I_Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design.Decorator
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            // Colors text in red.
            return $"\u001b[31m{base.GetText()}\u001b[0m"; 
        }
    }
}
