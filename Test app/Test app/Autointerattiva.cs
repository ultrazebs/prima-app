using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testApp;

namespace Test_app
{
    internal class Autointerattiva : Auto
    {
        
        public Autointerattiva()
        {

        }
        /// <summary>
        /// Metodo menu() che permette all'utente di scegliere fra varie opzioni possibili per la macchina
        /// </summary>
        public void menu()
        {
            int choice;

            do
            {
                // stampo il menu
                Console.WriteLine("Scegli tra le seguenti opzioni:");
                Console.WriteLine("0) Accendi;");
                Console.WriteLine("1) spegni;");
                Console.WriteLine("2) Rifornisci;");
                Console.WriteLine("3) Esci;");
                // prendo in input la risposta(scelta)
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(choice);
                // associo la scelta alle varie opzioni
                switch (choice)
                {
                    case 0:
                        // accendo l'auto
                        this.accendi();
                        this.stampaDescrizione();
                        break;
                    case 1:
                        // spengo l'auto
                        this.spegni();
                        this.stampaDescrizione();
                        break;
                    case 2:
                        // rifornisco l'auto -> carburante settato a 100
                        this.fuelLevel = 100;
                        Console.WriteLine("entrato nel case 2");
                        this.stampaDescrizione();
                        break;
                    case 3:
                        // esco
                        break;
                    default:
                        break;
                }
            }
            while (choice != 3);



        }
    }
}
