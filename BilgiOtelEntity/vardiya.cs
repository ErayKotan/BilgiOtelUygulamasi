using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelEntity
{
    public class vardiya
    {
        public int VardiyaId { get; set; }
        public string VardiyaTipi { get; set; }
        public DateTime VardiyaBaslangicSaati { get; set; } //bu ve alttaki veritabanında 'time' cinsinden 
        public DateTime VardiyaBitisSaati { get; set; }

    }
}
