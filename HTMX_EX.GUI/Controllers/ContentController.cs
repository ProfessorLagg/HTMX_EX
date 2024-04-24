using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTMX_EX.GUI.Controllers
{
	// https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
	[Route("content")]
	[ApiController]
	public class ContentController : ControllerBase
	{
		/// <summary>
		/// GET content/options
		/// </summary>
		/// <returns></returns>
		[HttpGet]
		[Route("options")]
		public async Task<IActionResult> GetOptions()
		{
			string HtmlString = @"<option value="""">--Please choose an option--</option><option value=""dog"">Dog</option><option value=""cat"">Cat</option><option value=""hamster"">Hamster</option><option value=""parrot"">Parrot</option><option value=""spider"">Spider</option><option value=""goldfish"">Goldfish</option>";

			return new ContentResult
			{
				ContentType = "text/html",
				Content = HtmlString
			};
		}
	}
}
