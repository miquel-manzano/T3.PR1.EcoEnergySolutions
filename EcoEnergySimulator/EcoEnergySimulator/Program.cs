using SimulationsLibrary;

internal class Program
{
    public static EnergySystem[]? SimulationsArray; // donde guardamos las simulaciones
    public static int CurrentSimulation; // Simulacion actual

    /// <summary>
    /// Initial menu of the program.
    /// </summary>
    /// <param name="args">numeros</param>
    private static void Main(string[] args)
    {
        const string MsgInvalidOption = "Opcio Erronea";
        // Pantalla inicial
        PrintTitle();
        int? opcio = null;
        bool validOption = false;
        while (!validOption)
        {
            PrintInitialMenu();
            opcio = UserInteractionHelper.UserIntInput();
            switch (opcio)
            {
                case 0:
                    SimulationScreen();
                    break;
                case 1:
                    ShowReport();
                    break;
                case 2:
                    validOption = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(MsgInvalidOption);
                    validOption = false;
                    break;
            }
        }
    }

    /// <summary>
    /// Menu on esculls the simulation to fer i configuration.
    /// </summary>
    public static void SimulationScreen()
    {
        Console.Clear();
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

        const string MsgInvalidOption = "Opcio Erronea";
        const string MsgCompletedSimulation = "Simulació completada i guardada.";

        int? opcio = null;
        bool validOption = false;

        EnergySystem? simulation = null;

        while (!validOption)
        {
            PrintSimulationMenu();
            opcio = UserInteractionHelper.UserIntInput();
            validOption = true;
            switch (opcio)
            {
                case 0:
                    Console.WriteLine();
                    simulation = new SolarSystem();
                    break;
                case 1:
                    Console.WriteLine();
                    simulation = new WindSystem();
                    break;
                case 2:
                    Console.WriteLine();
                    simulation = new HydroelectricSystem();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(MsgInvalidOption);
                    validOption = false;
                    break;
            }
        }
        simulation.SetParameters();
        SimulationsArray[CurrentSimulation] = simulation;
        CurrentSimulation++;
        Console.Clear();
        Console.WriteLine(MsgCompletedSimulation);
        return;
    }

    /// <summary>
    /// Function that shows the report of the simulations carried out.
    /// </summary>
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


    /// <summary>
    /// Functions that print important menus/texts.
    /// </summary>
    public static void PrintInitialMenu()
    {
        Console.WriteLine("Choose an option:\n0 - Start simulation\n1 - Show Report\n2 - Exit");
    }

    public static void PrintSimulationMenu()
    {
        Console.WriteLine("Choose a simulation:\n0 - Solar System\n1 - Wind System\n2 - Hydroelectric System");
    }

    public static void PrintTitle()
    {
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("\r\n\r\n                                                                                                                \r\n _____         _____                        _____ _           _     _                     _____ _             _ \r\n|   __|___ ___|   __|___ ___ ___ ___ _ _   |   __|_|_____ _ _| |___| |_ ___ ___    ___   |     |_|___ _ _ ___| |\r\n|   __|  _| . |   __|   | -_|  _| . | | |  |__   | |     | | | | .'|  _| . |  _|  |___|  | | | | | . | | | -_| |\r\n|_____|___|___|_____|_|_|___|_| |_  |_  |  |_____|_|_|_|_|___|_|__,|_| |___|_|           |_|_|_|_|_  |___|___|_|\r\n                                |___|___|                                                          |_|          \r\n\r\n");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
    }
}