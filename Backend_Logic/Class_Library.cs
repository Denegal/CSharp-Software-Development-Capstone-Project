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
        
    }

    public class FinanceList
    {
        public int ID { get; set; }
        public string IncomeExpense { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Client { get; set; }

    }
}
