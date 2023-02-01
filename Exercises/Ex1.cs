namespace Exercises
{
    internal class Ex1
    {
        public static void Exercise1(string input)
        {
            
            string[] sales = input.Split(',');
            int greatestConsectuvives = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] == "0")
                {
                    int cons = GetConsecutive(sales, i);
                    if (cons > greatestConsectuvives) { greatestConsectuvives = cons; }
                    i = i + cons; // Jump ahead in the list to avoid running GetConsecutive on all the consecutive 0s you just counted
                }
            }

            Console.WriteLine("Longest sequence of days without sale: " + greatestConsectuvives);

        }

        static int GetConsecutive(string[] array, int index)
        {
            int consecutive = 0;
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] == array[index])
                {
                    consecutive++;
                }
                else
                {
                    break;
                }
            }
            return consecutive;
        }


    }
}