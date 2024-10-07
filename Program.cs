string response;
do
{
    Console.Clear();
    Calculate();

    Console.Write("Would you like to calculate again? (Y/N): ");
    response = Console.ReadLine() ?? "";

} while (response.Equals("Y", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Press any key to exit...");
Console.ReadLine();

static void Calculate()
{
    // Inputs
    Console.Write("Enter the number of items: ");
    double itemCount = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter base clock speed: ");
    double baseClockSpeed = double.Parse(Console.ReadLine() ?? "0");
    double maxOverclock = baseClockSpeed * 2.5;

    // Outputs
    double clockspeed = 0;
    double numMachines = 0;

    for (double divisor = maxOverclock; divisor >= 1; divisor -= 0.001)
    {
        numMachines = Math.Round(itemCount / divisor, 3);
        double rest = Math.Round(itemCount % divisor, 3);

        if (rest == 0)
        {
            clockspeed = divisor;
            break;
        }
    }

    Console.WriteLine($"Clock Speed: {Math.Round(clockspeed, 3)}");
    Console.WriteLine($"Number Machines: {numMachines}");
}