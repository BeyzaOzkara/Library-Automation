using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Kitap : IDisposable
    {
        [Key]
        [Column(Order = 1)]
        public int BarkodNo { get; set; }
        public string KitapAdi { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakteri geçemez"), Display(Name = "Yazar")]
        public string Yazar { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakteri geçemez"), Display(Name = "Yayinevi")]
        public string Yayinevi { get; set; }
        public int SayfaSayisi { get; set; }
        public int BasimYili { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
