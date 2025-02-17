public class PayLaterDTO
{
    public int Id { set; get; }
    public int EmployeeId { set; get; }
    public string note { set; get; }
    public double value { set; get; }
    public DateTime Date { get; set; }
    public EmployeeDTO Employee { set; get; }

}