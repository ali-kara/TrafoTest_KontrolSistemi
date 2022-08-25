using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafoTest_Model.Model
{
    public class ISLEM_RECETE
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ISLEM_RECETE_ID { get; set; }
        public int ISLEM_BASLIK_ID { get; set; }
        public int RECETE_ID { get; set; }
        [StringLength(50)]
        public string RECETE_ADI { get; set; }
        public int? ADIM { get; set; } = 0;
        public double? SAAT { get; set; } = 0;
        public int? DERECE { get; set; } = 0;
        public bool? ISITMA { get; set; } = false;
        public bool? VAKUM { get; set; } = false;
        public int? VAKUM_DEGERI { get; set; } = 0;
        public bool? TAHLIYE { get; set; } = false;
        public int? TAHLIYE_DEGERI { get; set; } = 0;
        [StringLength(250)]
        public string ACIKLAMA { get; set; }
        [StringLength(50)]
        public string TOPLAM_ZAMAN { get; set; }
        public double? TOPLAM_SURE { get; set; } = 0;
        public DateTime? EKLE_LOG_TARIH { get; set; }

        public virtual ISLEM_BASLIK Islem_Baslik { get; set; }
    }
}
