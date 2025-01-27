namespace EcoEnergySimulator
{
    public class UserInteractionHelper
    {
        public static double UserDoubleInput()
        {
            return double.Parse(Console.ReadLine());
        }
        public static int UserIntInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
