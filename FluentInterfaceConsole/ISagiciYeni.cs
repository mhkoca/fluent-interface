namespace FluentInterfaceConsole
{
    public interface ISabitlemedenSonra : IOtVer, IKovaAl
    {
    }
    public interface IOtVermedenSonra : IKovaAl
    {
    }
    public interface IKovaAldiktanSonra : ISag
    {
    }
    public interface ISabitle 
    {
        ISabitlemedenSonra Sabitle();
    }
    public interface IOtVer 
    {
        IOtVermedenSonra OtVer();
    }
    public interface IKovaAl 
    {
        IKovaAldiktanSonra KovaAl();
    }
    public interface ISag
    {
        void Sag();
    }
}
