using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafoTest_Model.Model
{
    [Table("EXCEPTION_LOG")]
    public class EXCEPTION_LOG
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EXCEPTION_LOG_ID { get; set; }
        public string MESSAGE { get; set; }
        public string STACKTRACE { get; set; }
        public string INNER_EXCEPTION { get; set; }
        public DateTime? EKLE_LOG_TARIH { get; set; } = DateTime.Now;

    } 
}
