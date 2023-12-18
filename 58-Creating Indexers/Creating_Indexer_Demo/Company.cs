﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Creating_Indexer_Demo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, Name = "Emily", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 8, Name = "Ben", Gender = "Male" });

        }


        // Creating Indexers
        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
    }
}