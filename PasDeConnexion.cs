using System;
using System.Runtime.Serialization;

namespace dotnet
{
    [Serializable]
    internal class PasDeConnexion : Exception
    {
        public PasDeConnexion()
        {
        }

        public PasDeConnexion(string message) : base(message)
        {
        }

        public PasDeConnexion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PasDeConnexion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}