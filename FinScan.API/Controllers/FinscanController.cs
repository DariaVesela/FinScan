using FinScan.API.Mappers;
using FinScan.API.Model;
using FinScan.Logic.Interfaces;
using FinScan.Model;
using Microsoft.AspNetCore.Mvc;

namespace FinScan.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FinscanController(IDataService dataService, FinscanControllerMapper map) : Controller
{
	[HttpGet("reports")]
	public async Task<ActionResult<IEnumerable<GetCompanyReportsByDateResponse>>> CompanyReports([FromQuery] string company, [FromQuery] DateOnly date)
	{
		var results = await dataService.GetCompanyReportsByDate(company, date);
		return Ok(map.ToApi(results));
	}
}
