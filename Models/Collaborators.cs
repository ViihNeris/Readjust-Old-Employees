using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReadjustNewOldEmployees.Models.OldCollaborators;

namespace ReadjustNewOldEmployees.Models
{
    internal class Collaborators
    {
        String EmployeeName;
        String JobTitle;
        protected double CurrentSalary;
        protected double Percent;
        protected double bonus;
        protected double NewSalary;

        public void ReadData()
        {

            Console.Write("\nNome do Colaborador: ");
            EmployeeName = Console.ReadLine();

            Console.Write("Cargo: ");
            JobTitle = Console.ReadLine();

            Console.Write("Salário Atual: ");
            CurrentSalary = Convert.ToDouble(Console.ReadLine());

            VerifyPercent();
        }

        public double VerifyPercent()
        {
            if (CurrentSalary <= 7000)
            {
                Console.Write("Digite o percentual do reajuste: ");
                Percent = Convert.ToDouble(Console.ReadLine()) / 100;
            }
            else
            {
                Percent = 0.1;
            }

            return Percent;
        }

        public void ProcessedData()
        {
            Console.WriteLine("\n------------ FICHA DO COLABORADOR ------------\n");
            Console.WriteLine("NOME: " + EmployeeName);
            Console.WriteLine("CARGO: " + JobTitle);
            Console.WriteLine("\nSalário antigo: " + CurrentSalary.ToString("C"));
            Console.WriteLine("SALÁRIO ATUALIZADO: " + NewSalary.ToString("C"));
            Console.WriteLine("\n-----------------------------------------------\n");

        }

        public String AskContinue()
        {
            Console.WriteLine("Deseja continuar o cálculo de reajuste?\n(Digite 'Sim' para continuar ou aperte ENTER para sair).");
            String resp = Console.ReadLine().ToLower();
            return resp;
        }
    }
}

