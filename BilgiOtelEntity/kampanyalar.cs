using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelEntity
{
    public class kampanyalar
    {
        public int KampanyaId { get; set; }
        public string KampanyaBilgileri { get; set; }
        public int KampanyaIndirimOran { get; set; }
        public DateTime KampanyaBaslangicZaman { get; set; }
        public DateTime KampanyaBitisTarihi { get; set; }
        public string KampanyaTanim { get; set; }
    }
}
