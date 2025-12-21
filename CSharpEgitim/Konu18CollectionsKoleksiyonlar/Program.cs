using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu18CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //koleksiyonlar birden fazla veriyi tek bir değişkende tutmamızı sağlar.
            //array'ler de birden fazla veriyi tek bir değişkende tutmamızı sağlar.
            //koleksiyonlar array'lere göre daha esnek ve kullanışlıdır.



            //Ornek1();
            //Ornek2();

            //Ornek4();
            //Ornek5();
            //Console.WriteLine("Merhaba");
            //rnek6();
            //Ornek8();
            ListKullanimi();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add("Merhaba");
            arrayList.Add(3.14);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


        }

        static void Ornek2()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ankara");
            arrayList.Add("Zonguldak");
            arrayList.Add("Merhaba");


            Console.WriteLine("Siralanmamis Liste:\n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine("A dan Z ye Siralanmis Liste:\n");
            arrayList.Sort();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine("Z dan A ye Siralanmis Liste:\n");
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }







        }

        static void Ornek3()
        {
            StringCollection stringCollection = new StringCollection();//sadece string veri tipi alir
            stringCollection.Add("Ankara");
            stringCollection.Add("Zonguldak");
            //hata alir int var cunku icinde stringCollection.Add(12);
            foreach (var item in stringCollection)
            {
                Console.WriteLine(item);
            }


        }

        static void Ornek4()
        {
            StringDictionary stringDictionary=new StringDictionary();
            stringDictionary.Add("06","Ankara");
            stringDictionary.Add("34","Istanbul");
            foreach (var item in stringDictionary.Keys)
            {
                Console.WriteLine("Key: "+item+" Value: "+stringDictionary[item.ToString()]);

            }
        }

        static void Ornek5()
        {
            Stack stack=new Stack();
            stack.Push(12);
            stack.Push("Merhaba");
            stack.Push(3.14);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());

            }
        }

        static void Ornek6()
        {
            Queue queue=new Queue();
            queue.Enqueue(12);
            queue.Enqueue("Merhaba");
            queue.Enqueue(3.14);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        static void Ornek7()
        {
            Hashtable hashtable=new Hashtable();
            hashtable.Add(06,"Ankara");
            hashtable.Add(34,"Istanbul");
            hashtable.Add(35,"Izmir");
            Console.WriteLine("Anahtarlar");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine("Key: {0} Value: {1}", item, hashtable[item]);

            }
        }

        static void Ornek8()
        {
            Dictionary<string,string> keyValuePairs=new Dictionary<string, string>();
            keyValuePairs.Add("06", "Ankara");
            keyValuePairs.Add("34", "Istanbul");
            keyValuePairs.Add("35", "Izmir");
            keyValuePairs["16"] = "Bursa";//Add methodu yerine bu sekilde de ekleme yapabiliriz.
            Console.WriteLine(keyValuePairs["35"]);
        }

        class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Lastname { get; set; }



        }

        static void ListKullanimi()
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Malatya");
            sehirler.Add("Istanbul");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Contains("Malatya"));// bu degeri iceriyor mu?
            foreach(var i in sehirler)
            {
                Console.WriteLine(i);
            }
            List<User> users = new List<User>();
            users.Add(new User { Id=1, FirstName = "Ahmet", Lastname = "Yilmaz" });
            users.Add(new User { Id = 2, FirstName = "Mehmet", Lastname = "Kaya" });
            users.Add(new User { Id = 3, FirstName = "Ayse", Lastname = "Demir" });
            List<User> kullanicilar = new List<User>()
            {
               new User { Id=1, FirstName = "Ahmet", Lastname = "Yilmaz" },new User { Id = 2, FirstName = "Mehmet", Lastname = "Kaya" },new User { Id = 3, FirstName = "Ayse", Lastname = "Demir" }
            };
            var yeniKullanici = new User
            {
                Id = 4,FirstName="Fatma",Lastname= "Celik"
            };
            kullanicilar.Add(yeniKullanici);
            kullanicilar.AddRange(users);//birden fazla ekleme yapar
        }

    }
}
