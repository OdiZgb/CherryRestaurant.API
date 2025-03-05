using System;

namespace Data
{
    public class EmployeeAttendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public Employee Employee { get; set; }
    }
}