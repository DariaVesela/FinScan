namespace FinScan.Model;

public class Report
{
	public FormType FormType { get; set; }
	public string? CompanyName { get; set; }
	public string? CIK {  get; set; }
	public DateOnly Date { get; set; }
	public string? Body { get; set; }
}
