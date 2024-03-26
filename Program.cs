using Decorator_Design.Concrete_Component;
using Decorator_Design.Decorator;

var component = new Concrete_Class();

// Create decorators
var plain_Decorator = new PlainDecorator(component);
var upperCase_Decorator = new UpperCaseDecorator(component);
var color_Decorator = new ColorDecorator(component);

// Use decorators
Console.WriteLine("Initial Text: " + component.GetText());
Console.WriteLine();
Console.WriteLine("Plain Text: " + plain_Decorator.GetText());
Console.WriteLine();
Console.WriteLine("Upper Case Text: " + upperCase_Decorator.GetText());
Console.WriteLine();
Console.WriteLine("Color Text: " + color_Decorator.GetText());
