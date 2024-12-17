﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Transaksi
    {
        [Key]
        public int id_transaksi { get; set; }
        [Required]
        public string tanggal_tansaksi { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public decimal harga_sewa { get; set; }
        [Required]
        public decimal harga_denda { get; set; }
        [Required]
        public string tanggal_pengambilan { get; set; }
        [Required]
        public string tanggal_pengembalian { get; set; }
        [ForeignKey("M_Akun")]
        public int id_akun {  get; set; }
        [ForeignKey("M_Buku")]
        public int Id_Buku { get; set; }
        [ForeignKey("M_MetodePembayaran")]
        public int metode { get; set; }
    }
}
