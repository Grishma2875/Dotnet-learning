using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
//using Dapper;
using Startsql.Models;

namespace Startsql.Controllers
{
    public class StartController : Controller
    {
        private readonly string? _connectionString;

        public StartController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IActionResult Index()
        {
            var sql = "SELECT * FROM Employees";

            var employees = new List<Employee>();

            using var connection = new SqlConnection(_connectionString);

            //employees = connection.Query<Employee>(sql).ToList();

            return View(employees);
        }
    }
}           