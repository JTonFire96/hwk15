using System;

namespace hwk15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO BEAR FIGHT!!! PRESS ANY KEY TO BEGIN!");
            Console.ReadKey();
            Console.WriteLine("Welcome to bear fight where bears duke it out in a tournament to see who is the most deadly bear. Press to continue--->");
            Console.ReadKey();
            Console.Write("And our first contestant is here. weighing 400 lbs and known for having the strongest  right hook in the forest its the unstoppable [ENTER NAME]");
            string bName = Console.ReadLine();

            bear brownBear = new bear(bName, 10, "brown");
            Console.WriteLine(" its the ustoppable {0} coming into the ring!!", bName);
           
            Console.WriteLine("{0}: RAWWAAARRRR!!!", bName);
            Console.ReadKey();
            Console.WriteLine(" Whoa there folks. That's an angry one, now this is probably the most deadly {0} bear in the forest.", brownBear._color);



            Console.ReadKey();
            
            Console.Write(" Now its time for the other contestant. A true technique specailist and deadly at their art, here comes unbreakable[ENTERNAME]");
            string pName = Console.ReadLine();
            panda fatPanda = new panda(pName, 15, "black and white", "China");
            Console.WriteLine("{0}: *strikes a deadly pose* ", pName);
            Console.ReadKey();
            Console.WriteLine("Ho boy!!! The crowd is going wild!!! This panda had his start from the rough jungles of {0} and he is here to show everyone what he got!", fatPanda._country);
            Console.ReadKey();
            Console.WriteLine("Alright enough talk! The fight is {0} versus {1}. Contestants are you ready?",bName,pName);
            Console.ReadKey();
            Console.WriteLine("{0}: RAAWARR!!!! ", bName);
            Console.WriteLine("{0}: *cracks knuckles*", pName);
            Console.ReadKey();
            Console.WriteLine("FIGHT!!!");
            Console.WriteLine("and so the bear fight went on for 5 hours. hundreds of animals killed but the winner stood high with the trophy of his struggle. this bear was [ENTER NAME]");
                
            
        }
    }
}
