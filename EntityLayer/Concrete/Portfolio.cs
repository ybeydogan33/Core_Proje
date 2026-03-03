using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Portfolio
{
        [Key]
        public int PortfolioID { get; set; }
        public string Title { get; set; } // Örn: Web Projeleri
        public string Category { get; set; } // Kartın altındaki küçük gri yazı
        public string ImageUrl { get; set; } // Proje görseli
        public string ProjectUrl { get; set; } // Tıklanınca gidilecek link
    }
