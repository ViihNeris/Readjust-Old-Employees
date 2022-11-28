using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadjustNewOldEmployees.Models
{

    internal class OldCollaborators : Collaborators
    {
        public void Readjustments()
        {
            bonus = CurrentSalary * Percent;
            NewSalary = CurrentSalary + bonus;
            Console.WriteLine("\n...Percentual aplicado: " + Percent * 100 + "%.");
            ProcessedData();
            
        }

        public class Messages : IMessages
        {
            public void Farewall()
            {
                Console.WriteLine("\nObrigada por utilizar o programa!");
     
            }
            

        }

    }

}
