//Pattern matching with C# switch expressions

// Value Pattern

// string color = "y";

// var result = color switch
// {
//     "r" => "Color is red",
//     "g" => "Color is green",
//     "b" => "Color is blue",
//     _ => "Unknown Color"
// };

// Console.WriteLine(result);



//Nornal switch


// PrintColorName("r");
// PrintColorName("g");
// PrintColorName("b");
// PrintColorName("aaa");


// void PrintColorName(string color)
// {
//     switch (color)
//     {
//         case "r":
//             Console.WriteLine("Red");
//             break;
//         case "g":
//             Console.WriteLine("Green");
//             break;
//         case "b":
//             Console.WriteLine("Blue");
//             break;
//         default:
//             Console.WriteLine("Unknown Color");
//             break;
//     }
// }




//Type pattern

// int age = 20;

// string name = "Sahasra Kesara";

// List<string> cities = new List<string> { "Colombo", "Negambo", "Kandy" };

// var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

// double salary = 100000.00;

// object CheckType(object val) => val switch
// {
//     int => "Integer Type",
//     string => "String Type",
//     List<string> => "Generic string list",
//     Array => "Array Type",
//     _ => "Unknown"
// };

// Console.WriteLine(CheckType(age));
// Console.WriteLine(CheckType(name));
// Console.WriteLine(CheckType(cities));
// Console.WriteLine(CheckType(numbers));
// Console.WriteLine(CheckType(salary));


//Realational Pattern

// var numbers = new List<int> { 1, -1, 11, 0, -5, 45 };

// foreach (var num in numbers)
// {
//     var res = num switch
//     {
//         >0 => $"{num} is a Positive Number",
//         0 => "This is Zero",
//         <0 => $"{num} is a Negative number"
//     };
//     Console.WriteLine(res);
// }


//Logical PAttern

// string CheckGrade(int m) => m switch
// {
//     < 15 => "Your grade is F",
//     >= 15 and < 35 => "Your grade is F",
//     >= 35 and < 55 => "Your Grade is C",
//     >= 55 and < 75 => "Your grade is B",
//     _ => "Your grade is A"
// };

// Console.WriteLine(CheckGrade(56));


// When Guard
var people = new List<Person>
{
    new ("John", "Doe", 44),
    new ("Saman", "Kumara", 20),
    new ("Jane", "Doe", 15),
    new ("Kenuli", "Thesara", 16)
};

string checkPerson(Person person)
{
    return person switch
    {
        { Age: var age } when age < 18 => "Minor person",
        _ => "Adult"
    };
}
foreach(var p in people)
{
    Console.WriteLine(checkPerson(p));
}
Console.ReadLine();

record Person(string FirstName, string LastName, int Age);