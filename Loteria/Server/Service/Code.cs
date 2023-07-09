using Loteria.Server.DATA;
using System;

namespace Loteria.Server.Service
{
    public class Code : ICode
    {
        private readonly ConnectMssql _connect;
        private readonly string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "W", "Y", "Z" };
        private readonly string[] alphabetNumeric = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private string result;
        Random rnd = new Random();
        Shared.Code codee = new Shared.Code();

        public Code(ConnectMssql connect)
        {
            _connect = connect;
        }

        public void GetCode(int longest, int HowMany)
        {
            for (int ik = 0; ik < HowMany; ik++)
            {
                var Password = new List<string>();
                for (int i = 0; i < longest; i++)
                {
                    int RandomTable = rnd.Next(1, 2);
                    if (RandomTable == 1)
                    {
                        Password.Add(alphabet[rnd.Next(0, alphabet.Count())]);
                    }
                    if (RandomTable == 2)
                    {
                        Password.Add(alphabetNumeric[rnd.Next(0, alphabetNumeric.Count())]);
                    }
                }
                result = string.Join("", Password);
                codee.id = Guid.NewGuid();
                codee.code = result;
                codee.DateTimeCreate = DateTime.Now;
                _connect.codes.Add(codee);
                _connect.SaveChanges();
            }

        }
    }
}
