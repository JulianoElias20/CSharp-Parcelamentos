﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcelamento.Entities
{
    internal class Installment
    {
        public DateTime DueDate {get; set;}
        public double Amount { get; set;}

        

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;

        }

        public override string ToString()
        {
            return Amount +" "+DueDate.ToString("dd/MM/yyyy");
        }

    }
}
