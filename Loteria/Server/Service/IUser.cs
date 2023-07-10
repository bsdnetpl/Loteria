using Loteria.Shared;

namespace Loteria.Server.Service
{
    public interface IUser
    {
        Shared.User AddUser(UserDTO userDTO);
    }
}
