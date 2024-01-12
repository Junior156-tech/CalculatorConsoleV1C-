//Calc version 1

Options();
int OptionNum = default;
bool pass = true;

while (pass)
{
    string? option = Console.ReadLine();
    Console.Clear();

    if (!int.TryParse(option, out OptionNum))
    {
        Console.WriteLine("Please digit a number");
        Console.WriteLine();
        Options();
    }
    else
    {
        if (OptionNum >= 5 || OptionNum <= 0)
        {
            Console.WriteLine("Select a digit in the range");
            Console.WriteLine();
            Options();
        }
        else
        {
            pass = false;
        }
    }
}

var Selected = SelectedType(OptionNum);
var result = Calc(Selected);
Console.WriteLine($"The {Selected} of this nums is: {result}");

double Calc(string SelectedType)
{
    string QuantityNumbers = string.Empty;
    int number = default;
    double FinalResult = 0;


    while (number == 0)
    {
        Console.Write($"How many numbers you want {SelectedType}: ");
        QuantityNumbers = Console.ReadLine()!;


        if (!int.TryParse(QuantityNumbers, out number))
        {
            Console.Clear();
            Console.WriteLine("Please select a number");
        }
        else
        {
            int acc = 0;

            for (int i = 1; i <= number; i++)
            {
                int result = 0;
                while (result == 0)
                {
                    Console.Write($"Number {i}: ");

                    string valueInit = string.Empty;
                    valueInit = Console.ReadLine();

                    if (!int.TryParse(valueInit, out result))
                    {
                        Console.Clear();
                        Console.WriteLine("Please select a number");
                    }
                }

                ++acc;

                if(acc == 1)
                    FinalResult = result;

                if(acc == 2)
                {
                    switch (SelectedType)
                    {
                        case "sum":
                            FinalResult += result;
                            break;
                        case "rest":
                            FinalResult -= result;
                            break;
                        case "mult":
                            FinalResult *= result;
                            break;
                        case "division":
                            FinalResult /= result;
                            break;
                    }
                    acc = 1;
                }
            }
        }
    }
    return FinalResult;
}

string SelectedType(int option)
{
    string typeCalc = string.Empty;
    switch (option)
    {
        case 1:
            typeCalc = "sum";
            break;
        case 2:
            typeCalc = "rest";
            break;
        case 3:
            typeCalc = "mult";
            break;
        case 4:
            typeCalc = "division";
            break;
    }

    return typeCalc;
}

void Options()
{
    Console.WriteLine("Digit a option (num)");
    Console.WriteLine();
    Console.WriteLine("1-Sum");
    Console.WriteLine("2-Rest");
    Console.WriteLine("3-Multiplicacion");
    Console.WriteLine("4-Division");
    Console.WriteLine();
    Console.Write("Option: ");
}


