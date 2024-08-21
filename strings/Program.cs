// Formating string literals

// Escape
Console.WriteLine("Hello\nWorld");
Console.WriteLine("Tab\tTab\tTab");

Console.Write("The output directory is: ");
Console.WriteLine("C:\\windows\\output\\text.txt");
Console.WriteLine("The \"quote\" is");

Console.WriteLine(@"C:\output\abc.csv");


//Concatanate
string firstName = "Sahasra";
string greeting = "Hello, ";

string message = greeting + firstName + " welcome to our class";

Console.WriteLine(message);

//or you can this concatanate type
Console.WriteLine(greeting + firstName + " welcome to our class");

string message = "The file path is " + @"C:\windows\output.txt";

// String intepolation
string firstname = "kesara";
string message = $"Hello, {firstname}";
Console.WriteLine(message);

//or we can
Console.WriteLine($"Hello, {firstname}");

//or we can
string greeting = $"Hello, {firstname} - Today is {DateTime.Now}";
Console.WriteLine(greeting);