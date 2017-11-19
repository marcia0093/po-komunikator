using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Communicator.Model.Client
{ 

    public class Response
    {
        public Request Request { get; private set; }
        public int Code { get; private set; }
        public JToken Data { get; private set; }
        public bool Error { get; private set; }
        public string ErrorMessage { get; private set; }

        public Response(string responseString, Request request)
        {
            Request = request;
            //TODO: STWORZENIE I PRZYPISANIE Data z responseString (zdekodowa\c json i przypisa\c do dictionary)
            JObject data = JsonConvert.DeserializeObject<JObject>(responseString);
            Code = (int) data["code"];
            Data = data["data"]; // TODO Jak przypisac JToken to Dictionary??? ZMIENIC JTOKEN DO DICTIONARY: Dictionary<string, object>
            Error = (bool) data["error"];
            ErrorMessage = (string) data["errorMessage"];
        }
    }
}
