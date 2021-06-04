using System;
using System.Collections.Generic;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> Table1 = new List<Guest>();
            List<Guest> Table2 = new List<Guest>();

            List<string> Occupations = new List<string>();

            List<Guest> GuestList = new List<Guest>()
            {
                new Guest
                (
                    "Marilyn Monroe",
                    "entertainer",
                    "(1926 - 1962) American actress, singer, model"
                ),
                new Guest
                (
                    "Abraham Lincoln",
                     "politician",
                     "(1809 - 1865) US President during American civil war"
                ),
                (
                "Martin Luther King",
                 "activist",
                "(1929 - 1968)  American civil rights campaigner"
                ),

            };

            foreach (Guest individual in Guestlist)
            {

                if (Occupations.Contains(individual.Occupation))
                {
                    Table2.Add(individual);

                }
                else
                {
                    Table1.Add(individual);
                    Occupations.Add(individual.Occupation);
                }
            }
            List<tables> TableList = new List<tables>();

            TableList.Add("Table1", Table1);
            TableList[0].tablename = "Table1";
            TableList[1].tablename = "Table2";
            TableList[0].tablename = Table1;
            TableList[1].tablename = Table2;

            foreach (Tables guest in TableList)
            {
                Console.WriteLine($"{guest.Name} {guest.Occupation}");
            }
            foreach (Guest individual in guest.Tables)
            {
                Console.WriteLine($"{individual.Name} {individual.Occupation}");
            }

            public class Tables
        {
            public List<Guest> Tables { get; set; }
            public string Tablename { get; set; }

            publiv tables(string tablename, List<Guest> tables)
            {
                Tablename = tablename;
                Tables = tables;
            }
        }
    }
}
}
