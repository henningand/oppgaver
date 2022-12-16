using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace oppgaver
{
    public class OppgaveService
    {

        public OppgaveService() { }

        /// <summary>
        /// Løp igjennom tallene fra 100 til 1, og skriv de til konsollen. 
        /// Der tallene er delelig med 3 skriv Elv (og ikke tallet), 
        /// og der tallene delelig med 5 skriv is (og ikke tallet), 
        /// og der tallene er delelig med begge skriv Elvis (og ikke tallet).
        /// </summary>
        public void Print100Til1()
        {
            for(decimal i = 100; i > 0; i--)
            {
                string printMe = "";
                if (decimal.IsInteger((i / 3)))
                {
                    printMe = "Elv";
                }
                if (decimal.IsInteger((i / 5)))
                {
                    printMe += "is";
                }
                if (string.IsNullOrWhiteSpace(printMe))
                    Console.WriteLine(i);
                else
                    Console.WriteLine(printMe);
            }
        }


        /// <summary>
        /// Skriv en funksjon/program som rekursivt beregner de 20 neste tallene i følgende rekke, og skriver de i omvendt rekkefølge til konsollen.
        /// Rekken begynner med 0,1,1,2, der det neste tallen vil være summen av de to foregående tallene. (Ex. 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765)
        /// </summary>
        public void Tallrekke()
        {
            Stack<int> ints = new Stack<int>();
            ints.Push(0);
            ints.Push(1);
            ints.Push(1);
            ints.Push(2);
            FortsettTallrekke(1, ref ints);
            while(ints.Count > 0)
            {
                Console.WriteLine(ints.Pop());
            }

        }

        private void FortsettTallrekke(int secondLast, ref Stack<int> ints)
        {
            if(ints.Count < 24)
            {
                int previous = ints.Peek();
                ints.Push(secondLast + previous);
                FortsettTallrekke(previous, ref ints);
            }
        }


        /// <summary>
        /// Skriv en funksjon/program som sjekker om en streng er et palindrom.
        /// </summary>
        /// <param name="ord"></param>
        public void PalindromSjekk(string ord)
        {
            bool res = ord.SequenceEqual(ord.Reverse());
            if (res) 
                Console.WriteLine("Det er palindrom");
            else
                Console.WriteLine("Det er IKKE palindrom");
        }
    }
}
