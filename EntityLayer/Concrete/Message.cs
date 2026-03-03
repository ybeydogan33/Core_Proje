using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string SenderName { get; set; } // İsim
        public string SenderEmail { get; set; } // Email
        public string Subject { get; set; } // Başlık
        public string Content { get; set; } // Mesaj
        public DateTime Date { get; set; } // Gönderilme Tarihi
        public bool IsRead { get; set; } // Admin panelde okundu/okunmadı takibi için
    }
