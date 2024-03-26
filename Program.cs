using Decorator_Design.Concrete_Component;
using Decorator_Design.Decorator;

var component = new Concrete_Class();

// Create decorators
var plainDecorator = new PlainDecorator(component);
var upperCaseDecorator = new UpperCaseDecorator(component);
var colorDecorator = new ColorDecorator(component);

// Use decorators
Console.WriteLine("Initial Text: " + component.GetText());
Console.WriteLine();
Console.WriteLine("Plain Text: " + plainDecorator.GetText());
Console.WriteLine();
Console.WriteLine("Upper Case Text: " + upperCaseDecorator.GetText());
Console.WriteLine();
Console.WriteLine("Color Text: " + colorDecorator.GetText());