using System;
using System.Linq;
using System.Collections.Generic;

namespace Laboration3
{
    public class Menu
    {
        private Registry registry;
        public Menu(Registry registry)
        {
            this.registry = registry;
        }

        public void MainMenu()
        {
            //Loopar så länge user input inte är 4.
            Console.WriteLine("Menu");

            int selection;
            do
            {
                Console.WriteLine("[0]Skapa person");
                Console.WriteLine("[1]Multiplikation");
                Console.WriteLine("[2]Räkna");
                Console.WriteLine("[3]Slumpvis");
                Console.WriteLine("[4]List");
                Console.WriteLine("[5]Exit");

                Console.WriteLine("Insert Selection");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 0:
                        AddPerson();
                        break;

                    case 1:
                        Multiplikation();
                        break;
                    case 2:
                        //Kallar på metoden "Count"
                        Count();
                        break;
                    case 3:
                        //Kallar på metoden "MixedNumbers".
                        MixedNumbers();
                        break;
                    case 4:
                        MyList();
                        break;
                    case 5:
                        System.Environment.Exit(1);
                        break;
                    default:
                        //Ifall Userinput är varken 1,2,3 eller 4.
                        Console.WriteLine("Ogiltigt!");
                        break;
                }
            } while (selection != 5);

        }

       public void MyList() 
        {
            foreach (Person person in registry.Person)
            {
                registry.Person.OrderBy(person => person.Birthday);
                Console.WriteLine($" Birthday number: {person.Birthday} Type of Sex: {person.Sex} HairColor: {person.Haircolor} EyeColor : {person.EyeColor} Hairlength {person.Hairlength}cm ");
                Console.ReadLine();
            }
        }
        
        public void AddPerson()
        {
           
            double birthday;
            Console.WriteLine("Enter birthday");
            double.TryParse(Console.ReadLine(), out birthday);
            Console.WriteLine("Enter Sex  ");
            string sex = Console.ReadLine();
            Console.WriteLine("Enter HairColor");
            string haircolor = Console.ReadLine();
            Console.WriteLine("Enter HairLenght");
            int Hairlenght;
            int.TryParse(Console.ReadLine(), out Hairlenght);
            Console.WriteLine("Enter eyecolor");
            string eyecolor = Console.ReadLine();
            Console.WriteLine("Is this your person day of birth : {0}, sex: {1} haircolor : {2} hairlenght : {3}  eyecolor : {4}", birthday, sex, haircolor, Hairlenght, eyecolor);
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                registry.RegisterPerson(birthday, sex, haircolor, eyecolor, Hairlenght);
                Console.WriteLine("Your person was added to list..Press enter to continue!");
                Console.ReadLine();
                MainMenu();
            }
            else
            {
                AddPerson();
            }
            if (answer == "menu")
            {
                MainMenu();
            }
        }

        static void Count()
        {
            //Skapar en array med 5 platser.
            int[] numbers = new int[5];

            //Variabeln i som får värdet 0
            int i = 0;

            Console.WriteLine("Skriv in 5 nummer");

            while (i < 5) //WhileLoop som loopar fram tills att  i = 5.
            {
                //kollar om userinputen är en integer
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    //adderar i med +1 för varje user input.
                    i++;
                }
                else
                {
                    Console.WriteLine("Ogiltigt nummer, försök igen!");
                }

            }
            //lägger till en ny variabel "Average som tar medelvärdet av de siffror som finns i arrayen "numbers""
            double average = numbers.Average();
            int sum = numbers.Sum(); // tar summan av alla tal i numbers
            int MaxValue = numbers.Max(); //tar det högsta värdet av alla tal i numbers
            int MinValue = numbers.Min(); // tar lägsta talet i numbers.

            //Skriver ut summan,medelvärdet, största samt lägsta värdet i arrayen numbers.
            Console.WriteLine("Summan av talen är: {0} ", sum);
            Console.WriteLine("Medelvärdet av talen är: {0} ", average);
            Console.WriteLine("Största talet är: {0}", MaxValue);
            Console.WriteLine("Minsta värdet är: {0} ", MinValue);
            Console.ReadLine();
            Console.Clear();
        }

        static void MixedNumbers()
        {
            //Skapar 2 ints en Min och en max
            int Min = 0;
            int Max = 20;
            //Skapar en array
            int[] numbers = new int[5];
            //Skapar en variabel Random
            Random randNum = new Random();

            //Går igenom hela arrayen och kastar om siffrorna.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randNum.Next(Min, Max);
            }

            //Sorterar siffrorna i arrayen i storleksordning.
            Array.Sort(numbers);

            //Listar alla värden i numbers.
            foreach (int value in numbers)
            {
                Console.WriteLine("Sorterade : {0} ", value);
            }
            Console.ReadLine();
            Console.Clear();

        }


        static void Multiplikation()
        {


            int a, b, c, d;
            Console.WriteLine("Ange ett värde: ");
            a = Convert.ToInt32(Console.ReadLine()); // anger ett värde

            Console.WriteLine("Ange ett annat värde: "); // anger ett annat värde
            b = Convert.ToInt32(Console.ReadLine());
            for (d = 1; d <= b; d++) // Här loopar dn fram tills att d = b alltså det andra värdet som användaren anger. T.ex om a=2 och b = 10 så blir det 2*1 = 2 fram tills 2*10 = 20.
            {
                c = a * d;
                Console.WriteLine("{0}*{1}={2}", a, d, c);
            }

            Console.ReadLine();
            Console.Clear();

        }




    }



}



