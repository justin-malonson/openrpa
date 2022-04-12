﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRPA
{
    [Serializable()]
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message)
            : base(message)
        {
        }
        protected BusinessRuleException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
    [Serializable()]
    public class LockNotReceivedException : Exception
    {
        public LockNotReceivedException(string message)
            : base("Get lock failed. " + message)
        {
        }
        protected LockNotReceivedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }

}
namespace OpenRPA.Interfaces
{
    [Serializable()]
    public class ElementNotFoundException : Exception
    {
        public ElementNotFoundException(string message)
            : base(message)
        {
        }
        protected ElementNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

    }
    [Serializable()]
    public class SocketException : Exception
    {
        public SocketException(string message)
            : base(message)
        {
        }
        protected SocketException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

    }
}
