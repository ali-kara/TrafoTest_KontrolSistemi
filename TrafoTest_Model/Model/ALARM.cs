using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafoTest_Model.Model
{
    [Table("ALARMLAR")]
    public class ALARM
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ALARM_ID { get; set; }
        public int? TANK_ID { get; set; }
        public int ISLEM_BASLIK_ID { get; set; }
        [StringLength(250)]
        public string ACIKLAMA { get; set; }
        public DateTime? OLUSMA_TARIHI { get; set; } = DateTime.Now;

        public virtual ISLEM_BASLIK IslemBasliklar { get; set; }
    }
}
