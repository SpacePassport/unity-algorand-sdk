using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AlgoSdk
{
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
    [Conditional("UNITY_EDITOR")]
    public sealed class AlgoApiObjectAttribute : ProvideSourceInfoAttribute
    {
        public AlgoApiObjectAttribute(
            [CallerMemberName] string member = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0
        ) : base(member, filePath, lineNumber) { }
    }
}
