using System;

namespace Laboration3
{
    public class Person
    {


        public double Birthday { get; set; }
        public string Sex { get; set; }
        public string Haircolor { get; set; }
        public string EyeColor { get; set; }
        public int Hairlength { get; set; }


        public Person(double birthday, string sex, string haircolor, string eyecolor, int hairlenght)
        {
            Birthday = birthday;
            Sex = sex;
            Haircolor = haircolor;
            Hairlength = hairlenght;
            EyeColor = eyecolor;
        }
    }



}

