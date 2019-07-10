using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_3
{
    class Program
    {
        static void Main(string[] args)
        {
             var tp = new TextProcessing();
              tp.Run();
            //new Blue().SayFavouriteFood(Red.FavouriteFood); 
            
                 
        }
    }
    class TextProcessing
    {
        Queue<string> names = new Queue<string>();
        public void Run()
        {
            //open the file and access the data
            using (StreamReader file = new StreamReader("U:/Users/742279/Assignment-3/names.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    
                    names.Enqueue(ln);
                   // Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                //post condition of while is:
               // We have now data member which is assign_3 queue
                PlayingwithStacks.Run(names);
            }
        }
    }

    class PlayingwithStacks
    {
        public static void Run(Queue<string> tangerine)
        {
            Stack<string> names = new Stack<string>();
            //how can i access queue var "names" in the class???
            //iterate over the queue
            // get each element
            // push it into the stack
            foreach (var item in tangerine)
            {
                //Console.WriteLine(names);
                names.Push(tangerine.Dequeue());
            }


        }
    }

    class Workbench { }

    class Red
    {
        public static string FavouriteFood = "Carrots";
    }

    class Blue
    {
        public void SayFavouriteFood(string FavFood)
            {
            Console.WriteLine(Red.FavouriteFood);
            }
    }
}
