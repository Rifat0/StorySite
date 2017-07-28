using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class Comment
    {
        public int id { get; set; }
        public int userid { get; set; }
        public Story storyid { get; set; }
        public int cmd { get; set; }
        public string rate { get; set; }
        public DateTime datetime { get; set; }
    }
}
