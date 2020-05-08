namespace Server.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Text { get; set; }

        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public Message(string text, Guid userId)
        {
            Text = text;
            UserId = userId;
        }

        public Message(string text, User user)
        {
            Text = text;
            User = user;
        }
    }
}
