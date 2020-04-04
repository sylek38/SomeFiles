using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WSBLab
{
    class EmployeeDb
    {
        ArrayList arrayLst = new ArrayList();

        Employee[] employees = new Employee[100];
        private int employeedIdx = 0;

        public void Add(Employee employee)
        {

            employees[employeedIdx++] = employee;
        }

        public void Print()
        {
            for (int i = 0; i<employeedIdx; i++)
            {
                employees[i].PrintInfo();
            }
        }

    }
}
