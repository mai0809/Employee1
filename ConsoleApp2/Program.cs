using System;
using System.Collections.Generic;
using System.Linq;
namespace PropertiesDeepDive
{
    static class Program
    {
        private static void Main()
        {
            Employee emp1 = new Employee();
            emp1.EmpName = "John Kar";
            emp1.EmpAdd = "Mehar";
            emp1.EmpId = 10000;
            Console.WriteLine("EmpName:{0}\nEmpAdd: {1} \nEmpId: {2}",
                emp1.EmpName, emp1.EmpAdd, emp1.EmpId);

            Employee emp2 = new Employee();
            emp2.EmpName = "John Roy";
            emp2.EmpAdd = "E";
            emp2.EmpId = 1001;
            Console.WriteLine("EmpName:{0}\nEmpAdd: {1} \nEmpId: {2}",
                emp2.EmpName, emp2.EmpAdd, emp2.EmpId);

            Employee emp3 = new Employee();
            emp3.EmpName = "Maitrayee Kar";
            emp3.EmpAdd = "f";
            emp3.EmpId = 1002;
            Console.WriteLine("EmpName:{0}\nEmpAdd: {1} \nEmpId: {2}",
                emp3.EmpName, emp3.EmpAdd, emp3.EmpId);


            Console.ReadLine();

        }
        public class Employee
        {
            private string _EmpName;
            private string _EmpAdd;
            private int _EmpId;

            public int EmpId
            {
                get
                {
                    return _EmpId;
                }
                set
                {
                    if (value < 0)
                        throw new Exception("Id can not be negative");
                    _EmpId = value;
                }
            }

            public string EmpName
            {
                get
                {
                    return _EmpName;
                }
                set
                {
                    if (value == null)
                        throw new Exception("Name can not be Null");
                    _EmpName = value;
                }
            }

            public string EmpAdd
            {
                get
                {
                    return _EmpAdd;
                }
                set
                {
                    if (value == null)
                        throw new Exception("add can not be Null");
                    _EmpAdd = value;
                }
            }
        }
    }
}