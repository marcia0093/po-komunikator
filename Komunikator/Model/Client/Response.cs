using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunikator.Model.Client
{ 

    public class Response
    {
        public Request Request { get; private set; }
        public Dictionary<string, object> Data { get; private set; }

        public Response(string responseString, Request request)
        {
            Request = request;
            //TODO: STWORZENIE I PRZYPISANIE Data z responseString (zdekodowa\c json i przypisa\c do dictionary)
        }
    }
}
