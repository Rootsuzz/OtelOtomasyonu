using System.ComponentModel.DataAnnotations;

namespace OtelOtomasyonu.Models
{
    public class Odalar
    {
        [Key]
        public int OdaId { get; set; }
            
        public int OdaKat { get; set; }

        public int OdaNumarasi { get; set; }

        public int KisiSayisi { get; set; }

        public bool KiralanmaDurumu { get; set; }



    }
}
