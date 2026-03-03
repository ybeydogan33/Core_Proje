using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Phone { get; set; } // Örn: +90 53X XXX XX XX
        public string Email { get; set; } // Örn: yavuz@beydogan.com
        public string Address { get; set; } // Örn: Türkiye
    }
