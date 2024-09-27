using Microsoft.EntityFrameworkCore;
using static DnDAPI.Models.Inventory;

namespace DnDAPI.Models
{
    public class DndContext : DbContext
    {
        public DndContext(DbContextOptions<DndContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; } = null!;
        public DbSet<Weapon> Weapons { get; set; } = null!;
    }
}
