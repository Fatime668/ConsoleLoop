using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Fatime", "Roya", "Aynura", "Gunel", "Qemer" };
            bool result = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Length>5)
                {
                    Console.WriteLine(name[i]);
                    result = true;
                }
                else
                {

                }
            }
            if (!result)
            {
                Console.WriteLine(false);
            }
        }
    }
}
