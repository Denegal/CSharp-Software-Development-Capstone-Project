using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Logic
{
    public class ClientList
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Waiver { get; set; }
        public bool Injuries { get; set; }
        public bool Pregnant { get; set; }
        public bool MedicalCare { get; set; }
        public int ClassCredit { get; set; }
    }
}
