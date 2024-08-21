// DisplayMeasurements(-4);
// DisplayMeasurements(16.0);
// DisplayMeasurements(12);
// DisplayMeasurements(Double.NaN);

// void DisplayMeasurements(double measurement)
// {
//     switch (measurement)
//     {
//         case double m when double.IsNaN(m):
//             Console.WriteLine("Failed measurement");
//             break;

//         case < 0.0:
//             Console.WriteLine($"Measured value {measurement} is too low");
//             break;

//         case > 15.0:
//             Console.WriteLine($"Measured value {measurement} is too high");
//             break;

//         default:
//             Console.WriteLine($"Measured value is {measurement}");
//             break;
//     }
// }

// void DisplayMeasurements(double measurement)
// {
//     switch (measurement)
//     {
//         case < 0:
//         case > 100:
//             Console.WriteLine($"The measurement is out of range");
//             break;
//         default:
//             Console.WriteLine($"The measurement is {measurement}");
//             break;
//     }
// }

DisplayMeasurements(3, 4);
DisplayMeasurements(4, 4);
DisplayMeasurements(-4, 20);
//switch guard
void DisplayMeasurements(int a, int b)
{
    switch ((a, b))
    {
        case( > 0, > 0 ) when a == b:
            Console.WriteLine($"The both measurements are valid and equal");
            break;
        case (>0, >0):
            Console.WriteLine($"The first measurement is {a}, second measurement is {b}.");
            break;
        default:
            Console.WriteLine("One of the measurements are not valid");
            break;
    }
}