using System;
using System.Data.Entity;

namespace MvcFileBasing.Models
{
    public class FileBasing
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Size { get; set; }
    }

}