using System;
using System.Linq;
using System.Collections.Generic;

namespace Laboration3
{
    class Program
    {
        public Program program;
        public Person person;
        public Registry registry;
        public Menu menu;


        static void Main(string[] args)
        {
            new Program().Run(); 
        }

        public Program()
        {
            registry = new Registry();
            menu = new Menu(registry);
        }

     

        private void Run() 
        {
            //test
            int hairlength = 5;
            string haircolor = "Red";
            int birth = 19920304;
            registry.RegisterPerson(birth, "Shemale", haircolor, "blue", hairlength);
            
            menu.MainMenu();
        }
    }

}


