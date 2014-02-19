using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human.Student> student_list = new List<Human.Student>
           {
                new Human.Student("Georgi", "Dimitrov", 2),
                 new Human.Student("Gergana", "Stoimenova", 5),
                 new Human.Student("Maria", "Petrova", 5),
                 new Human.Student("Stanismir", "Lazarov", 6),
                new Human.Student("Nikolai", "Motkurov", 6),
                new Human.Student("Katia", "Velikova", 3),
                new Human.Student("Valentina", "Dimitrova", 4),
                 new Human.Student("Zdravko", "Zdravkov", 3),
                 new Human.Student("Zahari", "Panajotov", 2),
                 new Human.Student("Ivancho", "Mariikov", 4)
           };
            var orderstudents = student_list.OrderBy(s => s.Grade);
         
            foreach (var item in orderstudents)
            {
                Console.WriteLine("\n------------------------------------" + "\nFirst Name= {0}  Grade ={1}", item.FirstName, item.Grade);

            }
            List<Human.Worker> worker_list = new List<Human.Worker>
            {
                new Human.Worker("Stanimir","Georgiev",145.4M,23),
                 new Human.Worker("Galia","Petrova",250.4M,23),
                  new Human.Worker("Atanas","Pyrvanov",300.4M,13),
                   new Human.Worker("Georgi","Ivanov",145.4M,6),
                    new Human.Worker("Stoil","Novobranski",134.4M,3),
                     new Human.Worker("Hristo","Iwanov",188.4M,2),
                      new Human.Worker("Maria","Hubawata",256.4M,3),
                       new Human.Worker("Kalin","GreenTeam",167.4M,8),
                        new Human.Worker("Petrana","Nikolova",254.5M,2),
                         new Human.Worker("STanislav","Hadjikostov",265.3M,9)
            };

            var worker = worker_list.OrderBy(w => w.MoneyPerHour());
         
            foreach (var item in worker)
            {
                Console.WriteLine("\n------------------------------------" + "\nFirst Name= {0}  Money per Hour ={1}", item.FirstName, item.MoneyPerHour());

            }
           


            List<Human.Human> humanlist = new List<Human.Human>
            {
                   new Human.Student("Georgi", "Dimitrov", 2),
                 new Human.Student("Gergana", "Stoimenova", 5),
                 new Human.Student("Maria", "Petrova", 5),
                 new Human.Student("Stanismir", "Lazarov", 6),
                new Human.Student("Nikolai", "Motkurov", 6),
                new Human.Student("Katia", "Velikova", 3),
                new Human.Student("Valentina", "Dimitrova", 4),
                 new Human.Student("Zdravko", "Zdravkov", 3),
                 new Human.Student("Zahari", "Panajotov", 2),
                 new Human.Student("Ivancho", "Mariikov", 4),
                   new Human.Worker("Stanimir","Georgiev",145.4M,23),
                 new Human.Worker("Galia","Petrova",250.4M,23),
                  new Human.Worker("Atanas","Pyrvanov",300.4M,13),
                   new Human.Worker("Georgi","Ivanov",145.4M,6),
                    new Human.Worker("Stoil","Novobranski",134.4M,3),
                     new Human.Worker("Hristo","Iwanov",188.4M,2),
                      new Human.Worker("Maria","Hubawata",256.4M,3),
                       new Human.Worker("Kalin","GreenTeam",167.4M,8),
                        new Human.Worker("Petrana","Nikolova",254.5M,2),
                         new Human.Worker("STanislav","Hadjikostov",265.3M,9)
            };

            var human = humanlist.OrderByDescending(h => h.FirstName);

            foreach (var item in human)
            {
                Console.WriteLine("\n------------------------------------" + "\n First Name= {0}  Possition={1}", item.FirstName,item.GetType().Name);
            }
            Console.ReadLine();
        }
    }
}
