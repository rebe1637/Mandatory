
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPserver1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(ip, 6789);
            //TcpListener serverSocket = new TcpListener(6789);
            //listener.Start();

            serverSocket.Start();



            while (true)
            {
                // Runs more times
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("Server activated");
                //NetworkStream ns = new NetworkStream(connectionSocket);
                //only on real sockets not TcpClient
                Stream ns = connectionSocket.GetStream();
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true;

                string message = sr.ReadLine();
                Console.WriteLine("Client: " + message);



                // make a if else statement to choose between someWeightInOunces and someWeightInGram


                if (message.Contains("ToGram"))
                {
                    string[] stringSplit = message.Split(' ');

                    double convertThisNumber = double.Parse(stringSplit[0]);

                    String svar = someWeightInOunces(convertThisNumber) + "grams";

                    sw.WriteLine(svar);
                    message = sr.ReadLine();

                }

                if (message.Contains("ToOunces"))
                {

                    string[] stringSplit = message.Split(' ');

                    double convertThisNumber = double.Parse(stringSplit[0]);

                    String svar = someWeightInGram(convertThisNumber) + "ounces";

                    sw.WriteLine(svar);
                    message = sr.ReadLine();
                }


            }




        }

        private static void Split(char v)
        {
            throw new NotImplementedException();
        }

        static public double someWeightInOunces(double numberToConvert)
        {
            return numberToConvert / 28.3495;
        }

        static public double someWeightInGram(double numberToConvert)
        {
            return numberToConvert * 28.3495;
        }


    }
}
