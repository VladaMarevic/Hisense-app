using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Product
    {
        [Required(ErrorMessage = "Sifru Proizovda je obavezna")] // anotacija
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Sifra proizvoda mora biti barem 10 karaktera")]
        public string? SifraProizvoda { get; set; }

        [Required(ErrorMessage = "Model Proizovda je obavezan.")]
        [StringLength(32, ErrorMessage = "Sifra ne moze biti veca od 32 karaktera.")]
        public string? ModelProizvoda { get; set; }

        [Required(ErrorMessage = "Sirina Proizovda je obavezna.")]
        [Range(0, int.MaxValue, ErrorMessage = "Sirina mora biti ceo broj.")]
        public int? SirinaUredjaja { get; set; }

        [Required(ErrorMessage = "Visina Proizovda je obavezna.")]
        [Range(0, int.MaxValue, ErrorMessage = "Visina mora biti ceo broj.")]
        public int? VisinaUredjaja { get; set; }

        [Required(ErrorMessage = "Dubina Proizovda je obavezna.")]
        [Range(0, int.MaxValue, ErrorMessage = "Dubina mora biti ceo broj.")]
        public int? DubinaUredjaja { get; set; }

        public Product(string sifraProizvoda, string modelProizvoda, int sirinaUredjaja, int visinaUredjaja, int dubinaUredjaja)
        {
            this.SifraProizvoda = sifraProizvoda;
            this.ModelProizvoda = modelProizvoda;
            this.SirinaUredjaja = sirinaUredjaja;
            this.VisinaUredjaja = visinaUredjaja;
            this.DubinaUredjaja = dubinaUredjaja;
        }

        public Product() { }

    }
}
