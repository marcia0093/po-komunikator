using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Communicator.Model.Client
{
    public class Client
    {
        public string Ip { get; private set; }
        public int Port { get; private set; }
        private TcpClient TcpClient;
        private StreamReader Reader;
        private StreamWriter Writer;
        public bool IsConnect { get; private set; }

        public Client(string ip, int port) {
            Ip = ip;
            Port = port;
        }

        public void Connect() {
            TcpClient = new TcpClient();
            try
            {
                TcpClient.Connect(Ip, Port);
                IsConnect = true;
            }
            catch (Exception e) {
                IsConnect = false;
                return;
            }
            Reader = new StreamReader(TcpClient.GetStream());
            Writer = new StreamWriter(TcpClient.GetStream());

        }

        public void Close() {
            TcpClient.Close(); 
            TcpClient = null;
        }

        public Response SendRequest(Request request)
        {
            Response response = null;

            switch (request.Code)
            {
                case Request.RequestType.Login:
                    {
                        
                        string loginRequest = JsonConvert.SerializeObject(request.Data);
                        Writer.WriteLine(loginRequest);
                        Writer.Flush();
                        string responseString = Reader.ReadLine();
                        if (responseString != null)
                        {
                            object dataReceived = JsonConvert.DeserializeObject(responseString);
                            response = new Response(responseString, request);
                        }
                        else {
                            response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Response is null.',
                            error: true,
                        }",
                        request
                        );
                        }
                    }
                    break;
               
            case Request.RequestType.Register:
                    {

                        string registerRequest = JsonConvert.SerializeObject(request.Data);
                        Writer.WriteLine(registerRequest);
                        Writer.Flush();
                        string responseString = Reader.ReadLine();
                        if (responseString != null)
                        {
                            object dataReceived = JsonConvert.DeserializeObject(responseString);
                            response = new Response(responseString, request);
                        }
                        else
                        {
                            response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Response is null.',
                            error: true,
                        }",
                        request
                        );
                        }
                    }
                    break;
            case Request.RequestType.NewChat:
                    {

                        string registerRequest = JsonConvert.SerializeObject(request.Data);
                        Writer.WriteLine(registerRequest);
                        Writer.Flush();
                        string responseString = Reader.ReadLine();
                        if (responseString != null)
                        {
                            object dataReceived = JsonConvert.DeserializeObject(responseString);
                            response = new Response(responseString, request);
                        }
                        else
                        {
                            response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Response is null.',
                            error: true,
                        }",
                        request
                        );
                        }
                    }
                    break;
                case Request.RequestType.GetChats:
                    {

                        string getChatsRequest = JsonConvert.SerializeObject(request.Data);
                        Writer.WriteLine(getChatsRequest);
                        Writer.Flush();
                        string responseString = Reader.ReadLine();
                        if (responseString != null)
                        {
                            object dataReceived = JsonConvert.DeserializeObject(responseString);
                            response = new Response(responseString, request);
                        }
                        else
                        {
                            response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Response is null.',
                            error: true,
                        }",
                        request
                        );
                        }
                    }
                    break;

                case Request.RequestType.SendMessage:
                    {

                        string sendMessRequest = JsonConvert.SerializeObject(request.Data);
                        Writer.WriteLine(sendMessRequest);
                        Writer.Flush();
                        string responseString = Reader.ReadLine();
                        if (responseString != null)
                        {
                            object dataReceived = JsonConvert.DeserializeObject(responseString);
                            response = new Response(responseString, request);
                        }
                        else
                        {
                            response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Response is null.',
                            error: true,
                        }",
                        request
                        );
                        }
                    }
                    break;
                case Request.RequestType.GetNewMessage:
                    {

                        string getNewMessRequest = JsonConvert.SerializeObject(request.Data);
                        Writer.WriteLine(getNewMessRequest);
                        Writer.Flush();
                        string responseString = Reader.ReadLine();
                        if (responseString != null)
                        {
                            object dataReceived = JsonConvert.DeserializeObject(responseString);
                            response = new Response(responseString, request);
                        }
                        else
                        {
                            response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Response is null.',
                            error: true,
                        }",
                        request
                        );
                        }
                    }
                    break;
                case Request.RequestType.Logout:
                    {

                        string logoutRequest = JsonConvert.SerializeObject(request.Data);
                        Writer.WriteLine(logoutRequest);
                        Writer.Flush();
                        string responseString = Reader.ReadLine();
                        if (responseString != null)
                        {
                            object dataReceived = JsonConvert.DeserializeObject(responseString);
                            response = new Response(responseString, request);
                        }
                        else
                        {
                            response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Response is null.',
                            error: true,
                        }",
                        request
                        );
                        }
                    }
                    break;
                default:
                    response = new Response(@"{
                            code: 1,
                            data: {},
                            errorMessage: 'Invalid request type.',
                            error: true,
                        }",
                        request
                        );
                    break;
            }
            
                return response;
        }



    }
}
