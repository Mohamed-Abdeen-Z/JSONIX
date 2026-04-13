using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Internal.Logger
{
    internal class Log
    {
        public static string Logger(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            var className = Path.GetFileNameWithoutExtension(filePath);

            string _msg = $"[File: {Path.GetFileName(filePath)}, Class: {className}, Method: {memberName}, Line: {lineNumber}] - Error: {message}";

            return _msg;
        }
    }
}
