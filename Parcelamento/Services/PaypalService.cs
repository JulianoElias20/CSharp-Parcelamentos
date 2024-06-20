using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcelamento.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
       public double Payment(double amount, double i, double month)
        {
            double media = amount / month;

           
            
                double calc1 = media * ((100 + i)/100);
                double calc2 = calc1 * 1.02;

                return calc2;


           

        }
    }
}
