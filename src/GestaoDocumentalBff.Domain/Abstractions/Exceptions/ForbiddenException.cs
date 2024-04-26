using System;
using System.Runtime.Serialization;

namespace GestaoDocumentalBff.Domain.Abstractions.Exceptions
{
    [Serializable]
    public class ForbiddenException : Exception
    {
        public ForbiddenException()
        {
        }

        public ForbiddenException(string message) : base(message)
        {
        }

        public ForbiddenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ForbiddenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
