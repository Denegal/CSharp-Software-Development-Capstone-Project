using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Logic
{
    public class ClientList
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Waiver { get; set; }
        public bool Injuries { get; set; }
        public bool Pregnant { get; set; }
        public bool MedicalCare { get; set; }
        public int Credits { get; set; }
        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 1:
                        return Last;

                    case 2:
                        return Phone;
                    
                    case 3:
                        return Email;
                    
                    case 8:
                        return Credits.ToString();

                    default:
                        return First;
                }
            }
        }
    }


}
