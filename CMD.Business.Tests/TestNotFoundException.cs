using System;
using System.Runtime.Serialization;

namespace CMD.Business.Tests
{
    [Serializable]
    internal class TestNotFoundException : Exception
    {
        public TestNotFoundException()
        {
        }

        public TestNotFoundException(string message) : base(message)
        {
        }

        public TestNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TestNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}