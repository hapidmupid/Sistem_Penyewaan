using Microsoft.AspNetCore.Mvc;
using Dapper;
using Sistem_penyewaan.Data;
using Sistem_penyewaan.Models;

namespace Sistem_penyewaan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KendaraanController : ControllerBase
    {
        private readonly DbContext _context;

        public KendaraanController(DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            using var conn = _context.CreateConnection();
            var data = conn.Query<Kendaraan>("SELECT * FROM kendaraan");

            return Ok(new { status = "success", data });
        }

        [HttpPost]
        public IActionResult Create(Kendaraan k)
        {
            using var conn = _context.CreateConnection();

            conn.Execute("INSERT INTO kendaraan (nama_kendaraan, harga_sewa) VALUES (@nama_kendaraan, @harga_sewa)", k);

            return Ok(new { status = "success", message = "Berhasil tambah kendaraan" });
        }
    }
}
