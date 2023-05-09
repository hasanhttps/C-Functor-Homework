using Funct.models;
using System.Security.Cryptography.X509Certificates;

namespace Funct {
    public delegate void Funct(string str);
    internal class Program {
        static void Main() {
            Console.WriteLine("Enter string");
            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Funct funcDell = cls.Space; // params sadece sizin ora vereceyiniz parametrlerdi burda funcDell-e functionlari verirsiniz
            funcDell += cls.Reverse;
            Run run = new Run();
            run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
        }
    }
}