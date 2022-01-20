using System;
namespace TicketManagementSystem.Models
{
    public class Tickets
{
    public int TicketId{get; set;}
    public int TicketNumber{get; set;}
    public DateTime TicketDate{get; set;}
    public int TicketIssueId{get; set;}
    public int EmployeeId{get; set;}
    public string ApprovalStatus{get; set;}
    public int ApprovedByUserId{get; set;}
}
}
