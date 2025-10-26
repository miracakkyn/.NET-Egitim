using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu17AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstract class'lardan nesne üretilemez.
            //Animal animal = new Animal(); //Hata
            //Abstract class'lar kalıtım için kullanılır.

            //interface'lerde olduğu gibi abstract class'larda da referans tip oluşturulabilir.
            //interfacelerde metodların gövdesi olmaz, abstract class'larda ise olabilir.
            //abstract classlar interfaceler ile classlarin karsiimi bir yapi
            //hem interdfaacelerin hemde classlarin yapisini barindirabiliyor

            //normal sinifklarda metod imzalarini kullanmamiyoruz ama abstract classlarda kullanabiliriz.
            //arayuzlerde sadece metod bildirimleri vardir, abstract classlarda ise hem bildirim hemde goviye olabilir.

            DataBase dataBase = new SqlServer();
            dataBase.Delete();
            dataBase.Add();
        }
    }
    abstract class DataBase {
    
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
        public abstract void Update();

        public abstract void Get();

        

    }
    class SqlServer : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Kayit sql serverdan silindi");
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Oracle : DataBase
    {

        public override void Delete()
        {
            Console.WriteLine("Kayit Oracledan silindi");       
        }

        public override void Get()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class MySql : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Kayit Mysqlden silindi");
        }
        public override void Get()
        {
            throw new NotImplementedException();
        }
        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
