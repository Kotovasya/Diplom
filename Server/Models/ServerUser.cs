using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Server.Models
{
    public struct ConnectionId : IEquatable<ConnectionId>
    {
        #region fields/constructor
        public static readonly ConnectionId Empty = new ConnectionId();

        public Guid Id { get; private set; }

        public bool IsTemporary { get; set; }

        public ConnectionId(Guid id, bool isTemporary = false)
        {
            Id = id;
            IsTemporary = isTemporary;
        }
        #endregion

        #region equals
        public static bool operator ==(ConnectionId left, ConnectionId right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ConnectionId left, ConnectionId right)
        {
            return !left.Equals(right);
        }

        public bool Equals(ConnectionId other)
        {
            return (Id == other.Id);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is ConnectionId))
                return false;
            return Equals((ConnectionId)obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * 411;
        }

        #endregion
    }

    public class ServerUser
    {
        public ConnectionId Connection { get; set; }
        public OperationContext OperationContext { get; set; }

        public ServerUser(ConnectionId connection, OperationContext context)
        {
            Connection = connection;
            OperationContext = context;
        }
    }
}
