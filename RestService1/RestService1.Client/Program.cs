using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Linq;
using RestService1.Entities;

namespace RestService1.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // First start the web project, then the client

            WebClient client = new WebClient();
            client.BaseAddress = "http://localhost:2795/";

            string xmlString = client.DownloadString("SampleService");

            XElement xml = XElement.Parse(xmlString);
            XNamespace ns = "http://schemas.datacontract.org/2004/07/RestService1.Entities";
            var items = from i in xml.Elements()
                        select new SampleItem
                        {
                            Id = (int)i.Element(ns + "Id"),
                            StringValue = i.Element(ns + "StringValue").Value
                        };

            foreach (var item in items)
            {
                Console.WriteLine("{0} {1}", item.Id, item.StringValue);
            }
        }
    }
}
