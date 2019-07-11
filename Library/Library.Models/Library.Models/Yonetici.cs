using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Yonetici : IDisposable
    {
        [Key]
        [Column(Order = 1)]
        public int YoneticiID { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakteri geçemez"), Display(Name = "Isim")]
        public string Isim { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakteri geçemez"), Display(Name = "Soyisim")]
        public string Soyisim { get; set; }
        [Required, StringLength(20, ErrorMessage = "20 karakteri geçemez"), Display(Name = "KullaniciAdi")]
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
