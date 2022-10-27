using System.Collections.Generic;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using Eshop.Models;
using Nhom_06.Models;

namespace Nhom_06.Data
{
    public class EshopContext : DbContext
    {

        public EshopContext(DbContextOptions<EshopContext> options)
        : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
       
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Review> reviews { get; set; }


    }
}
