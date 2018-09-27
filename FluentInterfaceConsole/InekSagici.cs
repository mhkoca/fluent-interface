using System;

namespace FluentInterfaceConsole
{
    public class InekSagici : ISagici
    {
        public ISagici Sabitle()
        {
            Console.WriteLine("Bağlandı");
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
            Console.WriteLine("İnek sağıldı");
            return this;
        }
    }
}
