namespace Sistem_penyewaan.Models
{
    public class Penyewaan
    {
        public int id { get; set; }
        public int pelanggan_id { get; set; }
        public int kendaraan_id { get; set; }
        public DateTime tanggal_sewa { get; set; }
        public DateTime tanggal_kembali { get; set; }
    }
}
