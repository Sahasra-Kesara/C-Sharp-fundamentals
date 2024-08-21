var dice = new Random();

var roll1 = dice.Next(1, 7);
var roll2 = dice.Next(1, 7);
var roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;



// conditional operators > < > >= <= != ==
// || &&


// var output = 2 > 3;
// Console.WriteLine(output);

//greater than 14 "You have won"
//less than 15 "You loose"


if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)) 
{
    Console.WriteLine("You have rolled a double, +2 points to the total");
    total += 2;
}

Console.WriteLine($"You have {roll1} + {roll2} + {roll3} = {total}");
Console.WriteLine($"The new total is {total}");


if (total > 10)
{
    Console.WriteLine("You win");
} 
else
{
    Console.WriteLine("You loose");
}