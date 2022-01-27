using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ConsoleApp1
{
    public class Item
    {
        public int id;
        public string name;
        public string type;
        public string dimension;
   
    }
    internal class Program
    {
        static void LoadJson<T>()
        {
            var strJ = new WebClient().DownloadString("https://rickandmortyapi.com/api/location/");
        
                List<T> items = JsonConvert.DeserializeObject<List<T>>(strJ);
             
        }
        static void Main(string[] args)
        {

            LoadJson();

        }

    }
}
