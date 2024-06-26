
namespace HTMX_EX.GUI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			var app = builder.Build();

			app.UseHttpsRedirection();

			app.UseAuthorization();
			app.UseStaticFiles();

			app.MapControllers();

			app.Run();
		}
	}
}
