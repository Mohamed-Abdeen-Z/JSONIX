using Internal.Logger;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace JSONIX.Exceptions
{
    public class IXException : Exception
    {
        public IXException(string message) : base(message)
        { }
    }

    // Body Of Main Library Exceptions
    public class IXActionFailedException : IXException
    {
        public IXActionFailedException(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0) : base(Log.Logger(message, memberName, filePath, lineNumber))
        { }
    }

    public class IXFormatErrorException : IXException
    {
        public IXFormatErrorException(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0) : base(Log.Logger(message, memberName, filePath, lineNumber))
        { }
    }

}
