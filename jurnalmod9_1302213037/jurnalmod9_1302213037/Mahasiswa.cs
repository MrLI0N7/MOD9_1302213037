namespace jurnalmod9_1302213037
{
    public class Mahasiswa
    {
        public string nama { get; set; }
        public string nim { get; set;}
        public List<string> Course { get; set;}
        public int year { get; set;}

        public Mahasiswa(string nama, string nim, List<string> Course, int year)
        {
            this.nama = nama; 
            this.nim = nim; 
            this.Course = Course; 
            this.year = year;
        }
    }
}
