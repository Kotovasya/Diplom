namespace Server.Data
{
    using Server.Data.Dto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class File : IDto<FileDto>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            Messages = new HashSet<Message>();
        }

        public File(string name, int size)
            : this()
        {
            Name = name;
            Data = new byte[size];
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public byte[] Data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }

        public FileDto ToDto()
        {
            return new FileDto(Id, Name, Data.Length);
        }

        /// <summary>
        /// Записывает данные в файл с заданного места
        /// </summary>
        /// <param name="offset">Место, с которого записываются данные</param>
        /// <param name="data">Данные, которые необходимо записать</param>
        public void WriteData(int offset, byte[] data)
        {
            Array.Copy(data, 0, Data, offset, data.Length);
        }

        /// <summary>
        /// Читает заданное количество данных из файла с заданного места
        /// </summary>
        /// <param name="offset">Место, с которого читаються данные</param>
        /// <param name="length">Количество байтов, которое необходимо считать</param>
        /// <returns></returns>
        public byte[] ReadData(int offset, int length)
        {
            byte[] data = new byte[length];
            Array.Copy(Data, offset, data, 0, length);
            return data;
        }
    }
}
