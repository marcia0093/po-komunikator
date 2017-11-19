using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunikator.Properties
{
    class Request
    {
        public static bool autentication(string user, string pass) {
            //wyslij do serwera zapytanie o autentykacje usera

            if (user == "admin" && pass == "admin")
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static int getUserIdByName(string user) {
            return 0;
        }

        public static bool register(string user, string mail, string pass) {
            //wyslij zapytanie do serwera o rejestracje

            return true;
        }

        public static void getFriendsList(string user) {
            //wyślij zapytanie do serwera o liste kontaktow
        }

        public static void getNewMessages() {
            //new messages
        }

        public static bool sendNewMessage(Komunikator.Entities.Message message) {
            return true;
        }

    }
}
