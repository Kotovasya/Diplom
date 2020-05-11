namespace Server.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Messages = new HashSet<Message>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }

        /// <summary>
        /// ������� ��������� �������
        /// </summary>
        /// <param name="id">ID �������</param>
        /// <param name="login">����� ������� (���)</param>
        /// <param name="password">������ �������</param>
        public User(Guid id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }
    }
}
