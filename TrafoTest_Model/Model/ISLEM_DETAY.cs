using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrafoTest_Model.Model
{
    [Table("ISLEM_DETAY")]
    public class ISLEM_DETAY
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ISLEM_DETAY_ID { get; set; }
        public int ISLEM_BASLIK_ID { get; set; }
        public double? SICAKLIK_1 { get; set; } = 0;
        public double? SICAKLIK_2 { get; set; } = 0;
        public double? SICAKLIK_3 { get; set; } = 0;
        public double? SICAKLIK_4 { get; set; } = 0;
        public double? SICAKLIK_5 { get; set; } = 0;
        public double? BASINC_1 { get; set; } = 0;
        public double? BASINC_2 { get; set; } = 0;
        public DateTime? EKLE_LOG_TARIH { get; set; } = DateTime.Now;

        public virtual ISLEM_BASLIK IslemBasliklar { get; set; }
    } 
}