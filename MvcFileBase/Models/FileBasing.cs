using System;
using System.Data.Entity;

namespace MvcFileBasing.Models
{
    public class FileBasing
    {
        public int Numbers { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Size { get; set; }
    }

    public class FileBaseDBContext : DbContext
    {
        public DbSet<FileBasing> FileBase { get; set; }
    }

}