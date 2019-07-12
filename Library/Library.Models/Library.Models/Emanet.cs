using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Emanet : IDisposable
    {
        [Key]
        [Column(Order = 1)]
        //[ForeignKey("Kitap")]
        public int EmanetID { get; set; }
        public int BarkodNo { get; set; }
        public int UyeID { get; set; }

        //[Column(TypeName = "date")]
        public DateTime VerilisTarihi { get; set; }
        //[Column(TypeName = "date")]
        public DateTime TeslimTarihi { get; set; }

        public Boolean TeslimDurumu { get; set; }

        public Kitap Kitap { get; set;}
        public Uye Uye { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
