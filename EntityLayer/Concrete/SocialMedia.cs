using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        public string Name { get; set; } // Örn: GitHub, LinkedIn
        public string Url { get; set; } // Profil linki
        public string IconClass { get; set; } // İkonun class'ı (Örn: fab fa-github)
        public bool Status { get; set; } // Sitede görünür/gizli ayarı
    }
