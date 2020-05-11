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
        /// ������� ��������� ��������� �� �������
        /// </summary>
        /// <param name="text">����� ���������</param>
        public Message(string text)
        {
            Text = text;
        }

        /// <summary>
        /// ������� ��������� ��������� �� ������� ��� �������������� �����
        /// </summary>
        /// <param name="text">����� ���������</param>
        /// <param name="userId">ID �������</param>
        public Message(string text, Guid? userId) 
            : this(text)
        {
            UserId = userId;
        }

        /// <summary>
        /// ������� ��������� ��������� �� ������� � ������������ ������
        /// </summary>
        /// <param name="text">����� ���������</param>
        /// <param name="userId">ID �������</param>
        /// <param name="fileId">ID �����</param>
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
