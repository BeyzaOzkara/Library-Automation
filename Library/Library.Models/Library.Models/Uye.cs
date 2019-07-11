using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Uye : IDisposable
    {
        [Key]
        [Column(Order = 1)]
        public int UyeID { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakteri geçemez"), Display(Name = "Isim")]
        public string Isim { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakteri geçemez"), Display(Name = "Soyisim")]
        public string Soyisim { get; set; }
        public Int64 TcNo { get; set; }

        public ICollection<Emanet> Emanet { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
