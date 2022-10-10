using AuctionApplication.Context;
using AuctionApplication.Entities;
using AuctionApplication.Entities.Identity;
using AuctionApplication.Interface.Repositories;
<<<<<<< HEAD
<<<<<<< HEAD
using Implementations.Repositories;
=======
>>>>>>> master
=======
>>>>>>> master
using Microsoft.EntityFrameworkCore;

namespace AuctionApplication.Implementations.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository 
    {
        public UserRepository(ApplicationContext Context)
        {
            _Context = Context;
        }
        public async Task<User> ExistsByEmailAsync(string email, string password)
        {
            var user = await _Context.Users.Include(user => user.UserRoles).ThenInclude( x => x.Role).FirstOrDefaultAsync(x => x.Email == email && x.Password == password && x.IsDeleted == false);
            return user;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public async Task<User> GetUserbyIdRoleAsync(int id, string role)
=======
        public async Task<User> GetUserByRoleName(int id, string role)
>>>>>>> master
=======
        public async Task<User> GetUserByRoleName(int id, string role)
>>>>>>> master
        {
            var result = await _Context.Users.Include(user => user.UserRoles).ThenInclude(x => x.Role).FirstOrDefaultAsync(x => x.Id == id && x.UserRoles.Any(y => y.Role.Name == role));
            return result;
        }
<<<<<<< HEAD
<<<<<<< HEAD

         
=======
>>>>>>> master
=======
>>>>>>> master
    }
}