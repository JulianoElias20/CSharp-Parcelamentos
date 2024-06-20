using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcelamento.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }

        public double TotalValue { get; set; }

       public List<Installment> Contracts { get; set; } 

        public Contract(int number, DateTime date, double value) 
        { 
            Number = number;
            Date = date;
            TotalValue = value;
            Contracts = new List<Installment>();


        }

        public void Add(Installment instal)
        {
            Contracts.Add(instal);

        }


    }
}
