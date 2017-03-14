using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HotelDBopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new HotelContext())
            {
                Console.WriteLine("Alt info om Hotel");
               

                var hoteller = from b in db.Hotel
                    select b;

                Console.WriteLine("Alle Hoteller i DB");
                foreach (var item in hoteller)
                {
                    Console.WriteLine("Navn"  +  item.Name + "Nummer" +  item.Hotel_No + "Adress" + item.Address);
                }

                

                var kunder = from g in db.Guest
                    select g;

                Console.WriteLine("Alle Kunder i DB");
                foreach (var item in kunder)
                {
                    Console.WriteLine("Navn"  +  item.Name  +  "Nummer" + item.Guest_No + "Adresse" + item.Address);
                }

                Console.WriteLine("Press shit to exit...");
                Console.ReadKey();

                var room = from h in db.Hotel
                           join r in db.Room on db.Hotel

            }
            


        }
    }
}
