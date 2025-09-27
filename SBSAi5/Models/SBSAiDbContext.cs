using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SBSAi5.Models
{
    public class SBSAiDbContext : DbContext
    {
        public SBSAiDbContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<Category> Categories{ get; set; } //Bảng Categories
        public DbSet<Book> Books { get; set; } //Bảng Books
        public DbSet<Member> Members { get; set; } //Bảng Members

    }
}