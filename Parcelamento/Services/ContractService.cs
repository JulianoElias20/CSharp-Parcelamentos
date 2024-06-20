using Parcelamento.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parcelamento.Services
{
    internal class ContractService
    {
        public Contract ccontract { get; set; }
        public int Month { get; set; }

        private IOnlinePaymentService Online;

        private Installment insta;
        public ContractService(Contract contract, int month,IOnlinePaymentService online)
        {
            ccontract = contract;
            Month = month;
            Online = online;


        }
        public void ProcessContract()
        {


            //double media = ccontract.TotalValue/Month;
            for (int i = 1; i <= Month; i++)
            {
               DateTime m= ccontract.Date.AddMonths(i);
               double pay= Online.Payment(ccontract.TotalValue,i,Month);
              
                ccontract.Add(new Installment (m,pay));

            }
        }

        
    }
}
