namespace Topic_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Red", "White", "Blue", "Orange", "Purple" };
            Random generator = new Random();
            int randNum;
            randNum = generator.Next(5);
            Console.ReadLine(); // Keeps program from closin
            for (int i = 0; i< names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            if (randNum == 1)
            {
                Console.WriteLine(names[1]);
            }
            if (randNum == 2)
            {
                Console.WriteLine(names[2]);
            }
            if (randNum == 3)
            {
                Console.WriteLine(names[3]);
            }
            if (randNum == 4)
            {
                Console.WriteLine(names[4]);
            }
            if (randNum == 5)
            {
                Console.WriteLine(names[5]);
            }
        } // still cant figure out how to format it
    }
    
    
}
