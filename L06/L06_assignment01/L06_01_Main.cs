using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_assignment01
{
    class L06_01_Main
    {
        static void Main(string[] args)
        {
            EmployeeClass kirsi = new EmployeeClass();
            kirsi.Name = "Kirsi Kernel";
            kirsi.Profession = "Teacher";
            kirsi.Salary = 1200;
            Console.WriteLine("{0}:\n- Name: {1} Profession: {2} Salary: {3}\n","Employee",kirsi.Name,kirsi.Profession,kirsi.Salary);

            BossClass jussi = new BossClass();
            jussi.Name = "Jussi Jurkka";
            jussi.Profession = "Head of Institure";
            jussi.Salary = 9000;
            jussi.Car = "Audi";
            jussi.Bonus = 5000;
            Console.WriteLine("{0}:\n- Name: {1} Profession: {2} Salary: {3}\n","Boss", jussi.Name, jussi.Profession, jussi.Salary);

            //changing salaray
            kirsi.Salary = 2200;
            Console.WriteLine("{0}:\n- Name: {1} Profession: {2} Salary: {3}\n","Employee", kirsi.Name, kirsi.Profession, kirsi.Salary);
        }
    }
}
