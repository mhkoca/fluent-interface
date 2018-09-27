using System;

namespace FluentInterfaceConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            InekSagici inekSagici = new InekSagici();
            KoyunSagici koyunSagici = new KoyunSagici();
            InekSagiciYeni inekSagiciYeni = new InekSagiciYeni();

            Console.WriteLine("Yeni inek sağılacak");
            inekSagiciYeni.Sabitle().OtVer().KovaAl().Sag();

            Console.WriteLine("************");
            Console.WriteLine("İnek sağılacak");
            inekSagici.Sabitle().OtVer().Sag().KovaAl();

            Console.WriteLine("************");
            Console.WriteLine("Koyun sağılacak");
            koyunSagici.Sabitle().OtVer().KovaAl().Sag();

            Console.ReadLine();
        }
    }
}
