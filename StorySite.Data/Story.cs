using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class Story
    {
        public int id { get; set; }
        public int userid { get; set; }
        public int active_status { get; set; }
        public int category { get; set; }
        public string title { get; set; }
        public string story { get; set; }
        public DateTime datetime { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
