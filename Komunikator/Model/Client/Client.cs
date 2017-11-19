using System;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Komunikator.Model.Client
{
    public class Client
    {
        public string Ip { get; private set; }
        public int Port { get; private set; }
        private TcpClient TcpClient;
        private StreamReader Reader;
        private StreamWriter Writer;

        public Client(string ip, int port) {
            Ip = ip;
            Port = port;
        }

        public void Connect() {
            TcpClient = new TcpClient();
            TcpClient.Connect(Ip, Port);
            Reader = new StreamReader(TcpClient.GetStream());
            Writer = new StreamWriter(TcpClient.GetStream());

        }

        public void Close() {
            TcpClient.Close(); 
            TcpClient = null; //TODO: Sprawdzić czy tak powinno się robić
        }

        public Response SendRequest(Request request)
        {
            /*
            Writer.WriteLine(request.RequestString);

            return new Response(
                Reader.ReadLine(),
                request
            );
            */

            Response response = null;


            switch (request.Type)
            {
                case Request.RequestType.Login:
                    //TODO: Przykladowa walidacja
                    response = new Response(
                        "{" +
                            "\"code\": \"0\"" +
                            "\"data\": {" +
                                "\"isValid\": \"true\"" +
                            "}" +
                            "\"errorMessage\": \"\"" +
                            "\"error\": \"false\"" +
                        "}",
                        request
                        );
                    break;
                default:
                    response = new Response(
                        "{" +
                            "\"code\": \"1\"" +
                            "\"data\": {}" +
                            "\"errorMessage\": \"Invalid request type.\"" +
                            "\"error\": \"true\"" +
                        "}",
                        request
                        );
                    break;
            }

            return response;
        }



    }
}
