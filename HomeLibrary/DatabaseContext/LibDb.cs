using Microsoft.EntityFrameworkCore;
using ProjectModels;

namespace DbModel
{
    public class LibDb : DbContext
    {
        public DbSet<ProjectModels.Book> Books => Set<ProjectModels.Book>();
    }
}
