namespace Domain.Stores;

using Domain.Models;

public interface IUserStore
{
    public IEnumerable<UserModel> GetUsers();

    public UserModel GetUser(int userId);

    public UserModel AddUser(UserModel userToAdd);

    public int UpdateUser(UserModel userModelToUpdate);

    public bool DeleteUser(int userId);
}
