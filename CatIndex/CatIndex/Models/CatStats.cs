using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatIndex.Models
{
    public class CatStats
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Char Gender { get; set; }
        public String Picture { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime Until { get; set; }
        public Double Age { get; set; }
        public String[] Likes { get; set; }
        public String[] Dislikes { get; set; }
        public String Bio { get; set; }
        public String Breed { get; set; }
    }
}
