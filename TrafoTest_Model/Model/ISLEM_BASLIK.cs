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
    [Table("ISLEM_BASLIK")]
    public class ISLEM_BASLIK
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ISLEM_BASLIK_ID { get; set; }
        [StringLength(50)]
        public string ISLEM_ADI { get; set; }
        [StringLength(25)]
        public string TRAFO_1 { get; set; }
        [StringLength(25)]
        public string TRAFO_2 { get; set; }
        [StringLength(25)]
        public string TRAFO_3 { get; set; }
        [StringLength(25)]
        public string TRAFO_4 { get; set; }
        [StringLength(25)]
        public string TRAFO_5 { get; set; }
        [StringLength(25)]
        public string TRAFO_6 { get; set; }
        [StringLength(25)]
        public string TRAFO_7 { get; set; }
        [StringLength(25)]
        public string TRAFO_8 { get; set; }
        [StringLength(25)]
        public string TRAFO_9 { get; set; }
        [StringLength(25)]
        public string TRAFO_10 { get; set; }
        public int? TANK_ID { get; set; }
        [StringLength(250)]
        public string ACIKLAMA { get; set; }
        public DateTime? BASLANGIC_TARIHI { get; set; } = DateTime.Now;
        public DateTime? BITIS_TARIHI { get; set; }

        public virtual DbSet<ISLEM_DETAY> Islem_Detaylar { get; set; }
        public virtual DbSet<ISLEM_RECETE> Islem_Receteler { get; set; }
        public virtual DbSet<ALARM> Alarmlar { get; set; }
    }
}