using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Message
    {
        public String greetings = "Bonne Année";

        public String GetHelloMessage()
        {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                greetings = "Bon week-end " + Environment.UserName;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)
            {
                greetings = "Bon week-end " + Environment.UserName;
            }
            else if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 13)
            {
                greetings = "Zobi " + Environment.UserName;
            }
            else if (DateTime.Now.Hour >= 13 && DateTime.Now.Hour < 18)
            {
                greetings = "Bon après-midi " + Environment.UserName;
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour >= 18)
            {
                greetings = "Bon week-end " + Environment.UserName;
            }
            else
            {
                greetings = "Bonsoir " + Environment.UserName;
            }

            return greetings;
        }

           
        }
    }

