using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkeziUyg
{
    public class Cagri
    {
        public int Id { get; set; }
        public Boolean Turu { get; set; }
        public Musteri musteri { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
    }
}
