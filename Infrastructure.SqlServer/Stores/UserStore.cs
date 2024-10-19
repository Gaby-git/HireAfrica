namespace Infrastructure.SqlServer.Stores;

using Domain.Models;
using Domain.Stores;
using System.Collections.Generic;

public class UserStore :IUserStore
{
    public UserModel AddUser(UserModel userToAdd)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public UserModel GetUser(int userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<UserModel> GetUsers()
    {
        throw new NotImplementedException();
    }

    public int UpdateUser(UserModel userModelToUpdate)
    {
        throw new NotImplementedException();
    }
}
