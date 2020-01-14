using System;

namespace _18.uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cross 1 true/false:");
            bool x = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter cross 2 true/false:");
            bool y = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter cross 3 true/false:");
            bool z = Convert.ToBoolean(Console.ReadLine());

            // uzliku variantu ar visiem

            if (x && y && z)
            {
                Console.WriteLine("All crosses are ok!");
            }

            else

            { Console.WriteLine("Let's see who is who!"); }

            // pirmais variants ar katru 

            bool[] answers = new bool[] { x, y, z };

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i])
                {
                    Console.WriteLine($"Cross {i + 1} is ok");
                }
                else
                {
                    Console.WriteLine($"Cross {i + 1} is not ok");
                }
            }

            //for (int i = 0; i < answers.Length; i++)
            //{
            //    if (answers[i])
            //    {
            //        return (answers[i]);

            //    }
            //}
            //return false;

        }


    }
}


// Ir trīs krustojumi. Lietotājs, ievada informāciju par to, vai konkrētajam krustojumam var izbraukt cauri. 
// Programmai ir jāpārbauda, vai ir iespējams visiem krustojumiem izbraukt cauri. Jāizmanto bool tipa masīvs