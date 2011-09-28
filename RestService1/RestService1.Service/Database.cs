using System;
using System.Collections.Generic;
using System.Linq;
using RestService1.Entities;

namespace RestService1.Service
{
    static class Database
    {
        static Database()
        {
            Items = new Dictionary<int, SampleItem>
                {
                    { 1, new SampleItem{ Id = 1, StringValue = "Item 1"} },
                    { 2, new SampleItem{ Id = 2, StringValue = "Item 2"} },
                    { 3, new SampleItem{ Id = 3, StringValue = "Item 3"} },
                    { 4, new SampleItem{ Id = 4, StringValue = "Item 4"} },
                    { 5, new SampleItem{ Id = 5, StringValue = "Item 5"} },
                    { 6, new SampleItem{ Id = 6, StringValue = "Item 6"} },
                    { 7, new SampleItem{ Id = 7, StringValue = "Item 7"} },
                    { 8, new SampleItem{ Id = 8, StringValue = "Item 8"} },
                    { 9, new SampleItem{ Id = 9, StringValue = "Item 9"} }
                };
        }
        public static Dictionary<int, SampleItem> Items;
    }
}
