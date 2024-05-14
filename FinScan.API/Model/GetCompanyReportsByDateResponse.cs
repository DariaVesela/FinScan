namespace FinScan.API.Model;

public record GetCompanyReportsByDateResponse(
	string FormType,
	string CompanyName,
	string CIK,
	DateOnly Date,
	string Body);
