//Array

// string[] productIds = new string[5];

// productIds[0] = "A123";
// productIds[1] = "B123";
// productIds[2] = "C123";
// productIds[3] = "D123";
// productIds[4] = "E123";

//// Console.WriteLine($"First: {productIds[0]}");
//// Console.WriteLine($"Second: {productIds[1]}");
//// Console.WriteLine($"Third: {productIds[2]}");
//// Console.WriteLine($"Fourth: {productIds[3]}");

//foreach (variable in array) { }

// foreach (string id in productIds)
// {
//     Console.WriteLine($"Product id is {id}");
// }

int[] inventory = { 10, 100, 500, 800, 200, 20, 80, 100, 75, 50 };

int sum = 0;
int less50sum = 0;

foreach(var items in inventory)
{
    if (items > 50)
    {
        sum = sum + items;
    }
    else
    {
        less50sum = less50sum + items;
    }
}

Console.WriteLine($"You have a some of {sum} in the inventory");
Console.WriteLine($"You have a some of {less50sum} in the inventory (less 50)");