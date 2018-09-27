using System;

namespace FluentInterfaceConsole
{
    public class KoyunSagici : ISagici
    {
        public ISagici Sabitle()
        {
            Console.WriteLine("Kotra alanına alındı");
            return this;
        }

        public ISagici OtVer()
        {
            Console.WriteLine("Ot verildi");
            return this;
        }

        public ISagici KovaAl()
        {
            Console.WriteLine("Kova alındı");
            return this;
        }

        public ISagici Sag()
        {
            Console.WriteLine("Koyun sağıldı");
            return this;
        }
    }
}
