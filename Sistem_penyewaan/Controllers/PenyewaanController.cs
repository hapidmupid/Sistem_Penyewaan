using Microsoft.AspNetCore.Mvc;
using Dapper;
using Sistem_penyewaan.Data;
using Sistem_penyewaan.Models;

namespace Sistem_penyewaan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PenyewaanController : ControllerBase
    {
        private readonly DbContext _context;

        public PenyewaanController(DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            using var conn = _context.CreateConnection();

            var data = conn.Query(@"
                SELECT p.id, pl.nama, k.nama_kendaraan, p.tanggal_sewa
                FROM penyewaan p
                JOIN pelanggan pl ON p.pelanggan_id = pl.id
                JOIN kendaraan k ON p.kendaraan_id = k.id
            ");

            return Ok(new { status = "success", data });
        }

        [HttpPost]
        public IActionResult Create(Penyewaan p)
        {
            using var conn = _context.CreateConnection();

            conn.Execute(@"INSERT INTO penyewaan 
                (pelanggan_id, kendaraan_id, tanggal_sewa, tanggal_kembali)
                VALUES (@pelanggan_id, @kendaraan_id, @tanggal_sewa, @tanggal_kembali)", p);

            return Ok(new { status = "success", message = "Berhasil tambah penyewaan" });
        }
    }
}
