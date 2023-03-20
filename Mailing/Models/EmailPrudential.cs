using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
    public class EmailPrudential
    {
        public string pto { get; set; }

        public string psubject { get; set; }

        public string pcc { get; set; }

        public string pmsg { get; set; }

        public string papp { get; set; }

        public string pfrom { get; set; }

        public bool phtml { get; set; }

        public bool pisdebug { get; set; }
    }
}
