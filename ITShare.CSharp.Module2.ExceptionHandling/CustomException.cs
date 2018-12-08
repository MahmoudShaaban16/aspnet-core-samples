using System;
using System.Runtime.Serialization;

namespace ITShare.CSharp.Module2.ExceptionHandling
{
    [Serializable]
    internal class CustomException : Exception
    {
        public CustomException()
        {
        }

        public string ErrorCode { get; set; }
        public string SubErrorCode { get; set; }
        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}