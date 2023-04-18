using Microsoft.AspNetCore.Mvc;

namespace jurnalmod9_1302213037.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : Controller
    {
        public static List<string> mata_kuliah = new List<string>()
        {
            "PBO", "BD", "KPL", "SQA", "UX"
        };
        
        // membuat List of Mahasiswa yang berisi nama Mahasiswa
        public static List<Mahasiswa> ListMhs = new List<Mahasiswa>
        {
            new Mahasiswa("Liyan Made Leon WAYAN", "1302213037",mata_kuliah,2021),
            new Mahasiswa("Jaatsiyah Maulidina Astrianto", "1302213043",mata_kuliah,2021),
            new Mahasiswa("Rihan Hidayat", "1302210028", mata_kuliah, 2021),
            new Mahasiswa("Hilman Fariz Hirzi", "1302213092", mata_kuliah, 2021),
            new Mahasiswa("Putri Auliyah Rahma", "1302210033", mata_kuliah, 2021),

        };
        // Fungsi Get untuk mendapatkan semua buah yang ada di array
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMhs;
        }

        // Fungsi Get apabila diminta Mahasiswa untuk dengan index tertentu
        [HttpGet("{idx}")]
        public Mahasiswa Get(int idx)
        {
            return ListMhs[idx];
        }
        //Fungsi Post menambahkan Mahasiswa
        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa MahasiswaBaru)
        {
            ListMhs.Add(MahasiswaBaru);
            return Ok();
        }
        //Fungsi Delete Menghapus Mahasiswa dengan index tertentu
        [HttpDelete("{idx}")]
        public IActionResult Delete(int idx)
        {
            ListMhs.RemoveAt(idx);
            return Ok();
        }
       
    }
}
