using FinScan.Model;

namespace FinScan.Logic.Interfaces;
public interface IDataService
{
	Task<IEnumerable<Report>> GetCompanyReportsByDate(string CompanyName, DateOnly fromDate);
}