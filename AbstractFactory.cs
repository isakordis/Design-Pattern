using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9
{

    class Program
    {
        static void Main(string[] args)
        {
            //===============>>Abstract Factory
            UrunFactory ur = new Ols();
            ur.createHermes();
            ur.createGucci();
            ur.createChanel();
            Console.ReadLine();
        }
    }


    public interface UrunFactory
    {
        Gucci createGucci();
        Hermes createHermes();
        Chanel createChanel();

    }
    public interface Gucci { }
    public interface Hermes { }
    public interface Chanel { }

    public class Ols:UrunFactory
    {
        public Gucci createGucci()
        {

            return new _Gucci();
        }
        public Hermes createHermes()
        {
            return new _Hermes();
        }
        public Chanel createChanel()
        {
            return new _Chanel();
        }

       
    }
    public class _Gucci:Gucci
    {
        string sonuc= "Gucci Urunu 2017 model 50 Tl";
        public _Gucci()
        {
            Console.WriteLine(sonuc);
        }
        public string donder()
        {
            return sonuc;
        }
    }
    public class _Hermes : Hermes
    {
        string sonuc = "Hermes Urunu 2017 model 50 Tl";
        public _Hermes()
        {
            Console.WriteLine(sonuc);
        }
        public string donder()
        {
            return sonuc;
        }
    }
    public class _Chanel : Chanel
    {
        string sonuc = "Chanel Urunu 2017 model 50 Tl";
        public _Chanel()
        {
            Console.WriteLine(sonuc);
        }
        public string donder()
        {
            return sonuc;
        }
    }

}
    
   


