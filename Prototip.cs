using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============>>PROTOTIP ORNEGI
            Dogan dgm = new Dogan();
            dgm.AdSoyad = "Polat Alemdar";
            dgm.Dogum_tarihi = new DateTime(1971,01,01);
            Console.WriteLine("Dogan Kişi"+dgm.AdSoyad + " ID: " + dgm.ID);
            Memati mmt = new Memati();
            mmt.AdSoyad = "Pala Gözlüklü";
            mmt.Memati_Tarihi = DateTime.Now;
            mmt.Memati_Yası = 56;
            Console.WriteLine("Ölen Kişi"+mmt.AdSoyad+" ID: "+mmt.ID);
            Console.ReadLine();
        }
    }
    public abstract class Insan
    {
        public abstract Insan Clone();
        public string  AdSoyad { get; set; }
       
        public Guid ID { get; set; }
        public Insan()
        {
            this.ID = Guid.NewGuid();
        }
    }
    public class Dogan : Insan
    {
       
        public DateTime Dogum_tarihi { get; set; }
        public override Insan Clone()
        {
            return (Insan)MemberwiseClone();
        }

    }
    public class Memati : Insan
    {
        public int Memati_Yası { get; set; }
        public DateTime Memati_Tarihi { get; set; }
        public override Insan Clone()
        {
            return (Insan)MemberwiseClone();
        }

    }
}
