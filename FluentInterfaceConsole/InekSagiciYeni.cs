using System;

namespace FluentInterfaceConsole
{
    public class InekSagiciYeni :  IKovaAldiktanSonra, ISabitlemedenSonra, IOtVermedenSonra, ISag
    {
        public ISabitlemedenSonra Sabitle()
        {
            Console.WriteLine("Bağlandı");
            return this;
        }

        public IOtVermedenSonra OtVer()
        {
            Console.WriteLine("Ot verildi");
            return this;
        }

        public IKovaAldiktanSonra KovaAl()
        {
            Console.WriteLine("Kova alındı");
            return this;
        }       

        public void Sag()
        {
            Console.WriteLine("İnek sağıldı");
        }
    }
}
