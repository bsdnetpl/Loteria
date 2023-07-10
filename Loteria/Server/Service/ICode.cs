namespace Loteria.Server.Service
{
    public interface ICode
    {
        void GetCode(int longest, int HowMany);
        bool FindCode(string code);
        bool DeleteCode(string code);
    }
}
