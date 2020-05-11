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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public string Text { get; set; }

        public Guid? UserId { get; set; }

        public Guid? FileId { get; set; }

        public virtual File File { get; set; }

        public virtual User User { get; set; }

        /// <summary>
        /// ������� ��������� ��������� �� �������
        /// </summary>
        /// <param name="text">����� ���������</param>
        public Message(string text)
        {
            Text = text;
            UserId = null;
            FileId = null;
        }

        /// <summary>
        /// ������� ��������� ��������� �� ������� ��� �������������� �����
        /// </summary>
        /// <param name="text">����� ���������</param>
        /// <param name="userId">ID �������</param>
        public Message(string text, Guid? userId)
        {
            Text = text;
            UserId = userId;
            FileId = null;
        }

        /// <summary>
        /// ������� ��������� ��������� �� ������� � ������������ ������
        /// </summary>
        /// <param name="text">����� ���������</param>
        /// <param name="userId">ID �������</param>
        /// <param name="fileId">ID �����</param>
        public Message(string text, Guid? userId, Guid? fileId)
        {
            Text = text;
            UserId = userId;
            FileId = fileId;
        }

        public MessageDto ToDto()
        {
            return new MessageDto(Id, User.Login, Text, FileId, File.Name, File.Data.Length);
        }
    }
}
