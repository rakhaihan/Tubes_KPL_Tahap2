using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PoinSiswa_API.Models;
using PoinSiswa_API.Services;

namespace PoinSiswa_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Route: api/PoinPelanggaran
    public class PoinPelanggaranController : ControllerBase
    {
        private readonly PoinPelanggaranService _service = new(); // Inisialisasi service

        [HttpGet]
        // Mengambil semua data pelanggaran
        public ActionResult<List<PoinPelanggaran>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("siswa/{siswaId}")]
        // Mengambil semua pelanggaran berdasarkan ID siswa
        public ActionResult<List<PoinPelanggaran>> GetBySiswaId(int siswaId)
        {
            var result = _service.GetBySiswaId(siswaId);
            return result.Count == 0 ? NotFound() : Ok(result);
        }

        [HttpGet("{id}")]
        // Mengambil satu pelanggaran berdasarkan ID
        public ActionResult<PoinPelanggaran> GetById(int id)
        {
            var poin = _service.GetById(id);
            return poin == null ? NotFound() : Ok(poin);
        }

        [HttpPost]
        // Menambahkan pelanggaran baru
        public IActionResult Create([FromBody] PoinPelanggaran poin)
        {
            if (poin == null || !ModelState.IsValid)
                return BadRequest("Data pelanggaran tidak valid.");

            _service.Add(poin);
            return CreatedAtAction(nameof(GetById), new { id = poin.Id }, poin);
        }

        [HttpPut("{id}/status")]
        // Mengubah status pelanggaran (menunggu, disetujui, ditolak)
        public IActionResult UpdateStatus(int id, [FromBody] StatusPelanggaran status)
        {
            var success = _service.UpdateStatus(id, status);
            return success ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        // Menghapus pelanggaran berdasarkan ID
        public IActionResult Delete(int id)
        {
            var success = _service.Delete(id);
            return success ? NoContent() : NotFound();
        }

        [HttpGet("siswa/{siswaId}/total-disetujui")]
        // Mendapatkan total poin pelanggaran yang disetujui untuk siswa tertentu
        public IActionResult GetTotalPoinDisetujui(int siswaId)
        {
            var total = _service.GetTotalPoinDisetujuiBySiswa(siswaId);
            return Ok(new { SiswaId = siswaId, TotalPoin = total });
        }
    }
}
