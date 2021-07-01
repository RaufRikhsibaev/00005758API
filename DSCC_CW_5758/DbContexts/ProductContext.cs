using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSCC_CW_5758.Model;
using Microsoft.EntityFrameworkCore;

namespace DSCC_CW_5758.DbContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
