using Loteria.Server.DATA;
using Loteria.Shared;

namespace Loteria.Server.Service
{
    public class User : IUser
    {
        private readonly ConnectMssql _connect;

        public User(ConnectMssql connect)
        {
            _connect = connect;
        }

        public Shared.User AddUser(UserDTO userDTO)
        {
            
            Shared.User _user = new Shared.User();
            _user.Id = Guid.NewGuid();
            _user.Code = userDTO.Code;
            _user.Name = userDTO.Name;
            _user.PhoneNumber = userDTO.PhoneNumber;
            _user.EmailAddress = userDTO.EmailAddress;
            _user.SurName = userDTO.SurName;
            _user.DateTimeRegister = DateTime.Now;
            _connect.users.Add(_user);
            _connect.SaveChanges();
            return _user;
        }
    }
}
