// // Antarmuka Pembayaran yang sudah ada dalam aplikasi kita
// interface IPembayaran
// {
//     void ProsesPembayaran(int jumlah);
// }

// // Implementasi Pembayaran dalam aplikasi kita
// class PembayaranAplikasi : IPembayaran
// {
//     public void ProsesPembayaran(int jumlah)
//     {
//         Console.WriteLine("Menggunakan metode pembayaran dalam aplikasi: " + jumlah);
//     }
// }

// // Antarmuka Pembayaran pihak ketiga (misal: PayPal)
// interface IPembayaranPihakKetiga
// {
//     void DoPayment(double amount);
// }

// // Implementasi pembayaran dengan PayPal
// class PembayaranPayPal : IPembayaranPihakKetiga
// {
//     public void DoPayment(double amount)
//     {
//         Console.WriteLine("Menggunakan metode pembayaran PayPal: " + amount);
//     }
// }

// // Adapter untuk menghubungkan antarmuka IPembayaranPihakKetiga dengan IPembayaran
// class PembayaranAdapter : IPembayaran
// {
//     private IPembayaranPihakKetiga pembayaranPihakKetiga;

//     public PembayaranAdapter(IPembayaranPihakKetiga pembayaran)
//     {
//         pembayaranPihakKetiga = pembayaran;
//     }

//     public void ProsesPembayaran(int jumlah)
//     {
//         double amount = Convert.ToDouble(jumlah);
//         pembayaranPihakKetiga.DoPayment(amount);
//     }
// }

// // Client
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Membuat objek pembayaran dalam aplikasi
//         IPembayaran pembayaran = new PembayaranAplikasi();
//         pembayaran.ProsesPembayaran(100);

//         // Membuat objek pembayaran dengan PayPal melalui adapter
//         IPembayaranPihakKetiga pembayaranPayPal = new PembayaranPayPal();
//         IPembayaran adapter = new PembayaranAdapter(pembayaranPayPal);
//         adapter.ProsesPembayaran(200);
//     }
// }
