using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resruntPOS_ac0305
{
    class employeeclass
    {
        //employee naumber you have character and number.
        private string employeenumber;
        private string employeename;
        private int employeesalary;
        private string employeeadress;
        private DateTime dateofbarth;
        public employeeclass()
        {

        }
        public employeeclass(string employeenumber, string employeename,
            int employeesalary, string employeeadress,DateTime dateofbarth)
        {
            this.employeenumber = employeenumber;
            this.employeename = employeename;
            this.employeesalary = employeesalary;
            this.employeeadress = employeeadress;
            this.dateofbarth=dateofbarth;
        }
        public string  employee_number { get; set; }
        public  string employee_name { get; set; }
        public  int employee_salary { get; set; }
        public string employee_adress { get; set; }
        public DateTime Date_Of_Barth { get; set; }
    }
}
