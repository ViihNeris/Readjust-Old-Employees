using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadjustNewOldEmployees.Models;
using static ReadjustNewOldEmployees.Models.OldCollaborators;

namespace ReadjustNewOldEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OldCollaborators collaboratorX = new OldCollaborators();
            String resp = "sim";

            Console.WriteLine("\nREAJUSTE SALÁRIO DE COLABORADORES ANTIGOS");

            while (resp == "sim")
            {
                collaboratorX.ReadData();
                collaboratorX.Readjustments();
                resp = collaboratorX.AskContinue();
            }
            /*   1ª forma de chamar a interface:
             *   
             *   Messages msg = new Messages();
                 IMessages farewall = msg;

                 2ª forma (mais abreviada):
             */
            IMessages farewall = new Messages();
            farewall.Farewall();

            Console.Read();
        }
    }
}
