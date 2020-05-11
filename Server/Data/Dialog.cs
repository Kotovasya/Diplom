namespace Server.Data
{
    using Server.Data.Dto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dialog : IDto<DialogDto>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dialog()
        {
            Messages = new HashSet<Message>();
            Users = new HashSet<User>();
        }

        public Dialog(string name, ICollection<User> users) 
        {
            Name = name;
            Users = new HashSet<User>(users);
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public DialogDto ToDto()
        {
            return new DialogDto(Id, Name);
        }
    }
}
