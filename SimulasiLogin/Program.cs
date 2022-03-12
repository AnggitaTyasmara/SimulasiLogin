using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiLogin
{
    /// <summary>
    /// Main class
    /// </summary>
    /// <remarks> Class Data dapat menginput data berupa username dan password kemudian menampilkan status Login berhasil atau Login gagal</remarks>
    class Data
    {
        /// <summary>
        /// Deklarasi Variabel
        /// </summary>
        /// <param name="user">Mendaftarkan data username</param>
        /// <param name="pass">Mendaftarkan data password</param>
        /// <param name="username">Menginput ulang data username yang sudah di daftarkan</param>
        /// <param name="password">Menginput ulang data password yang sudah di daftarkan</param>
        public string user, pass, username, password, status;
        /// <summary>
        /// Input Data Username dan Password
        /// </summary>
        public void Input()
        {
            Console.Write("Daftarkan Username = ");
            user = Convert.ToString(Console.ReadLine());
            Console.Write("Daftarkan Password = ");
            pass = Convert.ToString(Console.ReadLine());
            Console.Write("Masukkan Username Anda = ");
            username = Convert.ToString(Console.ReadLine());
            Console.Write("Masukkan Password Anda = ");
            password = Convert.ToString(Console.ReadLine());
        }
        /// <summary>
        /// Menentukan Keterangan/Status
        /// </summary>
        /// <returns> Hasil dari menentukan apakah username dan password yang di inputkan sesuai dengan yang di daftarkan </returns>
        public string Keterangan()
        {
            string status;
            if (username == user && password == pass)
            {
                status = "Login Anda Berhasil ";
            }
            else
            {
                status = "Login Anda Gagal ";
            }
            return status;
        }
        /// <summary>
        /// Tampilan data Hasil
        /// </summary>
        public void Tampilan()
        {
            Console.WriteLine("\nStatus = {0}", Keterangan());
            Console.ReadKey();
        }
        /// <summary>
        /// Tampilan awal program Simulasi Login
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Data DT = new Data();
            DT.Input();
            DT.Keterangan();
            DT.Tampilan();
        }
    }
}
