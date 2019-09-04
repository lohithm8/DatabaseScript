using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakerBAL
{
    class Participant
    {
        public int Par_id { get; set; }
        public string First_name { get; set; }
        public string Mid_name { get; set; }
        public string Last_name { get; set; }
        public DateTime dob { get; set; }
        public string Gender { get; set; }
        public Int32 Mobile { get; set; }
        public string email { get; set; }
    }
}
