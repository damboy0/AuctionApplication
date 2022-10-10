using AuctionApplication.Entities;
namespace AuctionApplication.Implementations.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository 
    {
        public UserRepository(ApplicationContext Context)
        {
            _Context = Context;
        }
        public async Task<User> ExistsByEmailAsync(string Email, string Password)
        {
            var user = await _Context.Users.Include(user => user.UserRoles).ThenInclude( x => x.Role).FirstOrDefaultAsync(x => x.Email.Equal(Email) && x.Password.Equal(Password) && x.IsDeleted == false);
            return user;
        }

        public async Task<User> GetUserbyIdRoleAsync(int id, string role)
        {
            var result = await _Context.Users.Include(user => user.UserRoles).ThenInclude(x => x.Role).FirstOrDefaultAsync(x => x.Id == id && x.UserRoles.Any(y => y.Role.Name == role));
            return result;
        }

         
    }
}