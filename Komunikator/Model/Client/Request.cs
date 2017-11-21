using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Communicator.Model.Client
{
    public class Request
    {
        //TODO: Rozszerzyc RequestType w trakcie powstawania funkcjonalności
        public enum RequestType { Login, Register, SendMessage, GetMessage }

        public RequestType Type { get; private set; }
        public Dictionary<string, object> Data { get; private set; }

        public Request(RequestType type, Dictionary<string, object> data)
        {
            Type = type;
            Data = data;
        }

        public string RequestString
        {
            get
            {
                //TODO: stworzyć requestString (json) z pól w klasie Request (type i data)
                //ISITDONE? 
                string requestString = "";

                JToken serializeData = JsonConvert.SerializeObject(Type);
                JToken serializeRequest = JsonConvert.SerializeObject(this);
                requestString = (string)serializeRequest;

                return requestString;
            }

            //TODO: BRAK MOŻLIWOŚCI URUCHOMIENIA SETA (READONLY)
        }
    }
}
