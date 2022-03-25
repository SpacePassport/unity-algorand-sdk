using System;
using System.Runtime.InteropServices;

namespace AlgoSdk.Crypto
{
    internal static unsafe partial class sodium
    {
#if ((UNITY_IPHONE || UNITY_WEBGL) && !UNITY_EDITOR)
        internal const string Library = "__Internal";
#else
        internal const string Library = "sodium";
#endif

#if (!UNITY_WEBGL || UNITY_EDITOR)
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int sodium_init();
#endif

        [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr sodium_malloc(UIntPtr size);

        [DllImport(Library, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void sodium_free(IntPtr handle);
    }
}
