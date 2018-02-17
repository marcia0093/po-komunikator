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
        //public JToken Data { get; private set; }
        public Dictionary<string, object> Data { private set; get; } = new Dictionary<string, object>();
        public Dictionary<string, object> ChatsData { private set; get; } = new Dictionary<string, object>();
        public bool Error { get; private set; }
        public string ErrorMessage { get; private set; }

        public Response(string responseString, Request request)
        {
            Request = request;

            JObject data = JsonConvert.DeserializeObject<JObject>(responseString);
            Code = (int) data["Code"];
            //Data = (JToken) data["Data"];
            if (data["Id"] != null) {
                Data.Add("Id", data["Id"]);
            }
            if (data["Data"] != null) {
                Data.Add("Data", data["Data"]);
            }
            Data.Add("ResponseString", responseString);
            if (Code != 0)
            {
                Error = true;
            }
            else {
                Error = false;
            }   
            ErrorMessage = (string) data["ErrorMessage"];
        }

       
        
    }
}
