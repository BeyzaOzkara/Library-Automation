using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library.Models;


namespace Library.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("Library")
        {

        }
        public DbSet<Kitap> Kitap { get; set; }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<Yonetici> Yonetici { get; set; }
        public DbSet<Emanet> Emanet { get; set; }
    }
}
