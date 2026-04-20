using Microsoft.AspNetCore.Mvc;
using Dapper;
using Sistem_penyewaan.Data;
using Sistem_penyewaan.Models;

namespace Sistem_penyewaan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PelangganController : ControllerBase
    {
        private readonly DbContext _context;

        public PelangganController(DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            using var conn = _context.CreateConnection();
            var data = conn.Query<Pelanggan>("SELECT * FROM pelanggan");

            return Ok(new { status = "success", data });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using var conn = _context.CreateConnection();

            var data = conn.QuerySingleOrDefault<Pelanggan>(
                "SELECT * FROM pelanggan WHERE id = @id",
                new { id });

            if (data == null)
                return NotFound(new { status = "error", message = "Data tidak ditemukan" });

            return Ok(new { status = "success", data });
        }

        [HttpPost]
        public IActionResult Create(Pelanggan p)
        {
            using var conn = _context.CreateConnection();

            conn.Execute("INSERT INTO pelanggan (nama, email) VALUES (@nama, @email)", p);

            return Ok(new { status = "success", message = "Berhasil tambah data" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pelanggan p)
        {
            using var conn = _context.CreateConnection();

            conn.Execute(@"UPDATE pelanggan 
                           SET nama=@nama, email=@email, updated_at=NOW()
                           WHERE id=@id", new { p.nama, p.email, id });

            return Ok(new { status = "success", message = "Berhasil update" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using var conn = _context.CreateConnection();

            conn.Execute("DELETE FROM pelanggan WHERE id=@id", new { id });

            return Ok(new { status = "success", message = "Berhasil hapus" });
        }
    }
}
