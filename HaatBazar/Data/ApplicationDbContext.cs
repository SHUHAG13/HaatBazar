using HaatBazar.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace HaatBazar.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        // ===== MASTER TABLES =====

        public DbSet<CategoryMaster> categoryMaster { get; set; }
        public DbSet<ChildCategoryMaster> childCategoryMaster { get; set; }
        public DbSet<ProductMaster> productMaster { get; set; }
        public DbSet<CustomerMaster> customerMaster { get; set; }

        // ===== TRANSACTION TABLES =====

        public DbSet<CartMasterTbl> cartMasterTbl { get; set; }
        public DbSet<OrderMaster> orderMaster { get; set; }
        public DbSet<OrderDetailsTbl> orderDetailsTbl { get; set; }
    }
}
