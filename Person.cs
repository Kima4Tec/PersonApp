using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class Person
    {
        //-Fornavn
        string firstName;

        //- Efternavn
        string lastName;

        //- Højde
        double height;

        //- Vægt
        double weigth;

        //Properties: 4 stk der tilgår hver sin oplysning.
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Height { get => height; set => height = value; }
        public double Weigth { get => weigth; set => weigth = value; }

        //-Constructor uden parametre
        public Person()
        {

        }

        //- Constructor med parametrene Fornavn og Efternavn
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //- Constructor med parametre til alle oplysninger
        public Person(string firstName, string lastName, double height, double weigth)
        {
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weigth = weigth;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
        //-ToString


        //- GetBMI - Vægt i kg/(Højde i m * Højde i m)

        //- GetFullName

        //- SetFullName – med to strings som parameter

        //- SetFullName – med en string som parameter, hvis denne indeholder et ord skal det tilskrives LastName, og hvis den indeholder to eller flere ord, skal det sidste tilskrives LastName og resten tilskrives FirstName.


    }
}
