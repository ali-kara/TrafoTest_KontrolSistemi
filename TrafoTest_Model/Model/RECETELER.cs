using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafoTest_Model.Model
{
    [Table("RECETELER")]
    public class RECETELER
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RECETE_ID { get; set; }
        [StringLength(50)]
        public string RECETE_ADI { get; set; }
        public bool? PASIF { get; set; } = false;
        [StringLength(250)]
        public string ACIKLAMA { get; set; }
        public DateTime? EKLENME_TARIHI { get; set; } = DateTime.Now;
        public DateTime? GUNCELLEME_TARIHI { get; set; }

        public virtual DbSet<RECETE_DETAY> Recete_Detaylar { get; set; }

    }
}
