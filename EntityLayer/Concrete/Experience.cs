using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string Title { get; set; } // Örn: Yazılım Stajyeri
        public string Company { get; set; } // Örn: LC Waikiki
        public string DateRange { get; set; } // Örn: 2023 - 2024
        public string LogoUrl { get; set; } // Şirket logosu
    }