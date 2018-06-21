using System;
using System.Diagnostics;

namespace heroStory
{
    class Program
    {
        static void Main(string[] args)
        {

            ProcessStartInfo heroStart = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            heroStart.Arguments = "http://cinema-crazed.com/blog/wp-content/uploads/2016/01/superheromovie.jpg";

            ProcessStartInfo badPic = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            badPic.Arguments = "http://img.sparknotes.com/content/sparklife/sparktalk/nov28iconicvillainsbad3_Slide.jpg";

            ProcessStartInfo sidePic= new ProcessStartInfo("c:/Program Files (X86)/Google/Chrome/Application/Chrome.exe");
            sidePic.Arguments = "http://images.greenlabel.com/assets/2016/03/Editorial-Sidekicks1.jpg";

            ProcessStartInfo powerPic = new ProcessStartInfo("c:/Program Files (X86)/Google/Chrome/Application/Chrome.exe");
            powerPic.Arguments = "https://res.cloudinary.com/teepublic/image/private/s--fWAv20-I--/t_Preview/b_rgb:ffb81c,c_limit,f_jpg,h_630,q_90,w_630/v1513273362/production/designs/2178282_1.jpg";

            ProcessStartInfo fallingPic = new ProcessStartInfo("c:/Program Files (X86)/Google/Chrome/Application/Chrome.exe");
           fallingPic.Arguments = "https://static.zerochan.net/James.Bond.%28Character%29.full.1355614.jpg";

            ProcessStartInfo winningPic = new ProcessStartInfo("c:/Program Files (X86)/Google/Chrome/Application/Chrome.exe");
            winningPic.Arguments = "https://vignette.wikia.nocookie.net/animeandmangauniverse/images/d/d3/Hero_of_the_Hidden_Leaf.PNG/revision/latest?cb=20111213175017";
            
            Process.Start(heroStart);

            Console.WriteLine("It's the year 3000, Incredible strong and strange aliens have appeard all over earth...");
            Console.ReadKey();

            Console.Write("Their is one god. And his name is [Please enter name]: ");
            string godName = Console.ReadLine();

            superHuman bob = new superHuman(godName,100, 20);

            Console.WriteLine("{0} you have the power to do whatever you want, you have the health level of a mighty horse {1}, and your hit points are {2}", bob._name, bob._healthPoints, bob._hitPoints);
            Console.ReadKey();

            Console.WriteLine("........... ");
            Console.ReadKey();

            Process.Start(sidePic);

            Console.Write("Your sideKick has arrive [Please Enter Name]: ");
            string sidekick = Console.ReadLine();

            Console.Write("Please enter the location where {0} came from, [Enter location]: ", sidekick);
            string sidelocation = Console.ReadLine();

            Console.Write("Enter {0}, fighting style: ", sidekick);
            string fightstyle = Console.ReadLine();

            superHero dan = new superHero(sidekick, 100, 10, fightstyle, sidelocation);
            int _healthPoints = dan._healthPoints - 3;


            Console.WriteLine(".................");
            Console.ReadKey();

            Process.Start(badPic);

            Console.Write("... He has finally arrive, [Please enter Villans name]: ");
            string badname = Console.ReadLine();


            Console.WriteLine("{0}, is here for complete world destruction, all because we didnt take global warming seriously", badname);
            Console.ReadKey();

            Console.Write("{0} Doesnt look happy, he looks, [Enter villans mood]: ", badname);
            string badmood = Console.ReadLine();

            superVillain rob = new superVillain(badname, 100, 30, badmood, 130);
           

            Console.WriteLine("{0} is going after {1}, I should stop him!!!!", rob._name, dan._name);
            Console.ReadKey();

            Console.WriteLine("{0}, is trying to defend himself from the powerful punches that {1} is throwing at him", dan._name, rob._name);
            Console.ReadKey();


            int losehealth = dan._healthPoints - 40;
            Console.WriteLine("{0} health is decreasing from {1} to {2}", dan._name, dan._healthPoints, losehealth);
            Console.ReadKey();

            int losemorehealth = dan._healthPoints - 100;
            Console.WriteLine("{0}, Keeps hitting {1}, he cant take it, hes health level is {2}.... he has died. Noooooooooo!", rob._name, dan._name , losemorehealth);
            Console.ReadKey();

            Console.WriteLine("I will kill you for killing my sideKick");
            Console.ReadKey();
    
            Console.WriteLine("Rasengannnnn!!!!");
            Console.ReadKey();

            Process.Start(powerPic);

            int losebadhealth = rob._healthPoints - 100;
            Console.WriteLine("{0}, went from {1} to {2}, he has gone down!!!", rob._name, rob._healthPoints, losebadhealth);
            Console.ReadKey();

            Process.Start(fallingPic);

            Console.WriteLine("I may have lost a friend, but a war was won");
            Console.ReadKey();

            Process.Start(winningPic);

        }
    }
}
