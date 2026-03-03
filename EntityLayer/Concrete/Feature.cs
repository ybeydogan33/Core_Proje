using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Feature
    {
        [Key]
        public int FeatureID { get; set; }
        public string Name { get; set; } // Örn: Yavuz Beydoğan
        public string Title { get; set; } // Örn: Backend Developer
        public string Description { get; set; } // Örn: Ben Yavuz Beydoğan...
        public string ImageUrl { get; set; } // Profil fotoğrafı
        public string CvUrl { get; set; } // Özgeçmiş butonu linki
    }