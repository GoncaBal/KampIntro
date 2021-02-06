using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace GenericsMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(1, "Gonca");
            

            MyDictionary<int, string> ogrenciler2 = new MyDictionary<int, string>();
            ogrenciler2.Add(1,"Reyhan");
            ogrenciler2.Add(2, "Gonca");
            ogrenciler2.Add(3, "Hatice");
            ogrenciler2.Add(5, "Kenan");
            ogrenciler2.List();
        }
    }
}
