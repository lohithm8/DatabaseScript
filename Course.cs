using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBAL
{
    class Course
    {
        public int Course_id { get; set; }
        public string Course_name { get; set; }
        public int Speaker_id { get; set; }
        public  int Cost { get; set; }
        public string Course_desc { get; set; }
        public string Category { get; set; }
        public string Promo_code{ get; set; }
    }
}
