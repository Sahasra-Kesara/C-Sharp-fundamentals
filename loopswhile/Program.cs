// int i = 0;

// do
// {
//     //Always executes the first step
//     Console.WriteLine(i);
//     i++;
// } while(i<5);

/*Random random = new Random();
int current = random.Next(1, 11);
Console.WriteLine($"First generated number is {current}");
//int index = 1;

while(current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last generated number is {current}");
*/

/*do
{
    current = random.Next(1, 11);
    Console.WriteLine($"{index} - {current}");
    index++;

} while (current != 7);
*/


Random random = new Random();
int index = 0;
int current = 0;

do{
    current = random.Next(1, 11);
    

    if (current != 8) continue;  //break is the another option

    Console.WriteLine($"{index} - {current}");

    index++;

} while (current != 7);