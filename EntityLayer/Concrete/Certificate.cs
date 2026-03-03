using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Certificate
    {
        [Key]
        public int CertificateID { get; set; }
        public string Title { get; set; } // Örn: CCNA Introduction to Networks
        public string Provider { get; set; } // Örn: Cisco
        public string CertificateUrl { get; set; } // Görüntüle butonu linki
        public string LogoUrl { get; set; } // Sertifika sağlayıcının logosu
    }
