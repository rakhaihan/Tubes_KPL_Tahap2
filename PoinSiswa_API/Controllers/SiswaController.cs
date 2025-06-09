using Microsoft.AspNetCore.Mvc;
using PoinSiswa_API.Models;
using PoinSiswa_API.Services;

namespace PoinSiswa_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Route: api/Siswa
    public class SiswaController : ControllerBase
    {
        private readonly SiswaService _service = new(); // Inisialisasi service

        [HttpGet]
        // Mengambil semua data siswa
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        // Mengambil satu siswa berdasarkan ID
        public IActionResult GetById(int id)
        {
            var siswa = _service.GetById(id);
            return siswa == null ? NotFound() : Ok(siswa);
        }

        [HttpPost]
        // Menambahkan data siswa baru
        public IActionResult Add([FromBody] Siswa siswa)
        {
            if (siswa == null || !ModelState.IsValid)
                return BadRequest("Data siswa tidak valid.");

            _service.Add(siswa);
            return CreatedAtAction(nameof(GetById), new { id = siswa.Id }, siswa);
        }

        [HttpPut("{id}")]
        // Mengupdate data siswa berdasarkan ID
        public IActionResult Update(int id, [FromBody] Siswa siswa)
        {
            if (siswa == null || !ModelState.IsValid)
                return BadRequest("Data siswa tidak valid.");

            _service.Update(id, siswa);
            return NoContent();
        }

        [HttpDelete("{id}")]
        // Menghapus data siswa berdasarkan ID
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }

        [HttpPost("{id}/pelanggaran")]
        // Menambahkan pelanggaran ke siswa berdasarkan ID siswa
        public IActionResult TambahPelanggaran(int id, [FromBody] PoinPelanggaran pelanggaran)
        {
            if (pelanggaran == null || !ModelState.IsValid)
                return BadRequest("Data pelanggaran tidak valid.");

            _service.TambahPelanggaran(id, pelanggaran);
            return Ok(new { message = "Pelanggaran ditambahkan", pelanggaran });
        }
    }
}
