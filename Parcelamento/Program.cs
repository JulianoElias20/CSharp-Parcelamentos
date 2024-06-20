using Parcelamento.Entities;
using Parcelamento.Services;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number,date,price);


            Console.Write("Enter number of installments: ");
            int month = int.Parse(Console.ReadLine());

            ContractService cs = new ContractService(contract,month,new PaypalService());
            cs.ProcessContract();

            foreach (Installment obj in contract.Contracts)
            {
                Console.WriteLine(obj);
            }
           

            

        }
    }
}