using System;

namespace GestaoDocumentalBff.Domain.Abstractions.Exceptions
{
    [Serializable]
    public class MethodNotAllowedException : Exception
    {
        public MethodNotAllowedException()
        {
        }
    }
}