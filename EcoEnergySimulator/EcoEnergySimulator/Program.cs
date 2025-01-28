using SimulationsLibrary;

internal class Program
{
    public static EnergySystem[]? SimulationsArray; // donde guardamos las simulaciones
    public static int CurrentSimulation; // Simulacion actual

    /// <summary>
    /// My metodo es muy bonito.
    /// </summary>
    /// <param name="args">numeros</param>
    private static void Main(string[] args)
    {
        // Pantalla inicial
        Console.WriteLine("Welcomeeee!!");
        int? opcio = null;
        bool validOption = false;
        while (!validOption)
        {
            Console.WriteLine("Menu inicial");
            opcio = UserInteractionHelper.UserIntInput(2);
            switch (opcio)
            {
                case 0:
                    SimulationsScreen();
                    break;
                case 1:
                    ShowReport();
                    break;
                case 2:
                    validOption = true;
                    break;
                default:
                    Console.WriteLine("Opcio Erronea");
                    validOption = false;
                    break;
            }
        }
    }

    public static void SimulationsScreen()
    {
        if (SimulationsArray == null)
        {
            Console.WriteLine();
            SimulationsArray = new EnergySystem[UserInteractionHelper.UserIntInput(1)];
            CurrentSimulation = 0;
        }
        else if (SimulationsArray.Length == CurrentSimulation)
        {
            return;
        }

        int opcio = UserInteractionHelper.UserIntInput(2);
        bool validOption = false;

        EnergySystem simulacio = null;

        while (!validOption)
        {
            validOption = true;
            switch (opcio)
            {
                case 0:
                    Console.WriteLine();
                    simulacio = new SolarSystem();
                    break;
                case 1:
                    Console.WriteLine();
                    simulacio = new WindSystem();
                    break;
                case 2:
                    Console.WriteLine();
                    simulacio = new HydroelectricSystem();
                    break;
                default:
                    validOption = false;
                    opcio = UserInteractionHelper.UserIntInput(2);
                    break;
            }
        }
        simulacio.SetParameters();
        SimulationsArray[CurrentSimulation] = simulacio;
        CurrentSimulation++;
        Console.WriteLine("Simulació completada i guardada.");
        return;
    }

    public static void ShowReport()
    {
        Console.WriteLine("\nInforme de Simulacions:");
        Console.WriteLine("Data i Hora\t\tSistema\t\tEnergia Generada (kWh)");
        for (int i = 0; i < SimulationsArray.Length; i++)
        {
            Console.WriteLine(SimulationsArray[i]);
        }
        return;
    }
}