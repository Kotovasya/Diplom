namespace Server.Data
{
    using Server.Data.Dto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message : IDto<MessageDto>
    {
        /// <summary>
        /// Создает экземпляр сообщения от сервера
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        public Message(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Создает экземпляр сообщения от клиента без прикрепленного файла
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="userId">ID клиента</param>
        public Message(string text, Guid? userId) 
            : this(text)
        {
            UserId = userId;
        }

        /// <summary>
        /// Создает экземпляр сообщения от клиента с прикрепленым файлом
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="userId">ID клиента</param>
        /// <param name="fileId">ID файла</param>
        public Message(string text, Guid? userId, Guid? fileId) 
            : this(text, userId)
        {
            FileId = fileId;
        }


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public string Text { get; set; }

        public Guid? UserId { get; set; }

        public Guid? FileId { get; set; }

        public int DialogId { get; set; }

        public virtual File File { get; set; }

        public virtual User User { get; set; }

        public virtual Dialog Dialog { get; set; }

        public MessageDto ToDto()
        {
            return new MessageDto(Id, User.ToDto(), Dialog.ToDto(), Text, FileId, File.Name, File.Data.Length);
        }
    }
}
