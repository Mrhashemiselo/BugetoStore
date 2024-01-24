using BugetoStore.Application.Interfaces.Contexts;
using BugetoStore.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace BugetoStore.Persistence.Contexts
{
    public class DataBaseContext:DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        public int SaveChange(bool acceptAllChangesOnSuccess)
        {
            throw new NotImplementedException();
        }

        public int SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}
