using System;
namespace TicketManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeId{get; set;}
        public string EmployeeName{get; set;}
        public string EmployeeMail{get; set;}
        public DateTime EmployeeJoinDate{get; set;}
        public DateTime EMployeeBirthDate{get; set;}
        public int DepartmentId{get; set;}
        public int ProjectId{get; set;}
        public int ManagerId{get; set;}
    }
}