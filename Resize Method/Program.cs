namespace Resize_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int increment = 0;
            int[] numbers = new int[0];
            do
            {
                Console.WriteLine("Enter an element: ");
                int element = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[increment] = element;
                increment++;
                Console.WriteLine("Do you want to continue? ");
                string answer = Console.ReadLine();
                if (!(answer == "y" || answer == "Y"))
                {
                    flag = false;
                    Console.WriteLine(".......exiting");
                }

            } while (flag);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}