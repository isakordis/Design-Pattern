using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============>>Factory
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    IMantarGonder mantar = new MantarIsp();
                    mantar.Operation();
                    Console.WriteLine(i.ToString());
                }
                else if(i%11==0)
                {
                    IMantarGonder mantar = new MantarIsv();
                    mantar.Operation();
                    Console.WriteLine(i.ToString());
                }
                else
                {
                    IMantarGonder mantar = new MantarIng();
                    mantar.Operation();
                    Console.WriteLine(i.ToString());
                }
            }
            Console.ReadLine() ;
        }
    }
   
    public abstract class gun_belirtec
    {
      public abstract IMantarGonder GetMantar(); 
    }
    public abstract class IMantarIsv:gun_belirtec
    {
        public override IMantarGonder GetMantar()
        {
            return new MantarIsv();
        }

    }
    public abstract class IMantarIsp : gun_belirtec
    {
        public override IMantarGonder GetMantar()
        {
            return new MantarIsp();
        }
    }
    public abstract class IMantarIng : gun_belirtec
    {
        public override IMantarGonder GetMantar()
        {
            return new MantarIng();
        }
    }
    public interface IMantarGonder
    {
        void Operation();
    }
    class MantarIsv : IMantarGonder
    {
        public void Operation()
        {
            Console.WriteLine( "İsviçre Mantarı Gönderildi...");
        }
    }
    class MantarIsp : IMantarGonder
    {
        public void Operation()
        {
            Console.WriteLine( "İspanya Mantarı Gönderildi...");
        }
    }
    class MantarIng : IMantarGonder
    {
        public void Operation()
        {
            Console.WriteLine( "İngiltere Mantarı Gönderildi...");
        }
    }
}
