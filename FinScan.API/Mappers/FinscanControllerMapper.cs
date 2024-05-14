using FinScan.API.Model;
using FinScan.Model;

namespace FinScan.API.Mappers;

public class FinscanControllerMapper
{
	public GetCompanyReportsByDateResponse ToApi(Report report) => new(
		report.FormType.ToString(),
		report.CompanyName, // TODO: Nullcheck, null to empty string
		report.CIK,
		report.Date,
		report.Body);
	public IEnumerable<GetCompanyReportsByDateResponse> ToApi(IEnumerable<Report> reports) =>
		from report in reports
		select ToApi(report);
}
