namespace SimulationsLibrary
{
    public class UserInteractionHelper
    {
        public static double UserDoubleInput(double minValue)
        {
            double userNumber = 0;
            bool isValid;
            do
            {
                try
                {
                    userNumber = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    isValid = false;
                }
            } while (!isValid);
            return userNumber;
        }

        public static int UserIntInput(int minValue)
        {
            int userNumber = 0;
            bool isValid;
            do
            {
                try
                {
                    userNumber = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    isValid = false;
                }
            } while (!isValid);
            return userNumber;
        }
    }
}
