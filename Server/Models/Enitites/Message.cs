using Server.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Server.Models.Enitites
{
    public partial class Message
    {
        public int Id { get; set; }

        [Required]
        [StringLength(65535)]
        public string Text { get; set; }
        
        [Required]
        public User User { get; set; }

        public Message(string text, User user)
        {
            Text = text;
            User = user;
        }
    }
}
