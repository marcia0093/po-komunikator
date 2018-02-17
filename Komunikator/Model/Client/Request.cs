using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Communicator.Model.Client
{
    public class Request
    {
        //TODO: Rozszerzyc RequestType w trakcie powstawania funkcjonalności
        public enum RequestType { Login, Register, Logout, SendMessage, GetMessages, NewChat, GetChats, GetChat, HasNewMessage, GetNewMessage }

        public RequestType Code { get; private set; }
        //public Dictionary<string, object> Data { get; private set; }
        public Dictionary<string, object> Data { private set; get; } = new Dictionary<string, object>();

        public Request(RequestType type, Dictionary<string, object> data)
        {
            Code = type;
            Data = data;
        }

        /*public string RequestString
        {
            get
            {
                //TODO: stworzyć requestString (json) z pól w klasie Request (type i data)
                //ISITDONE? 
                string requestString = "";

                //JToken serializeData = JsonConvert.Serialize(Type);
                //JToken serializeRequest = JsonConvert.SerializeObject(this);
                // requestString = (string)serializeRequest;
                requestString = @"{
                     action: login,
                     login: admin,
                     password: admin
                     }

                 }";
                requestString = JsonConvert.SerializeObject(this);

                return requestString;
            }

            //TODO: BRAK MOŻLIWOŚCI URUCHOMIENIA SETA (READONLY)
        }*/
    }
}
