using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string Title { get; set; } // Örn: Google Yapay Zeka Akademi...
        public string Institution { get; set; } // Örn: Patika.dev
        public string DateRange { get; set; } // Örn: May 2024 - Halen
        public string LogoUrl { get; set; } // Kurum logosu
    }
