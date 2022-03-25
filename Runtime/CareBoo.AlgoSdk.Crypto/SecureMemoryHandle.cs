using System;
using Unity.Collections;
using Unity.Jobs;
using static AlgoSdk.Crypto.sodium;

namespace AlgoSdk.Crypto
{
    public struct SecureMemoryHandle
        : INativeDisposable
    {
#if (!UNITY_WEBGL || UNITY_EDITOR)
        static SecureMemoryHandle()
        {
            sodium_init();
        }
#endif

        public IntPtr Ptr;

        internal SecureMemoryHandle(IntPtr ptr)
        {
            Ptr = ptr;
        }

        public static SecureMemoryHandle Create(UIntPtr sizeBytes)
        {
            var ptr = sodium.sodium_malloc(sizeBytes);
            return new SecureMemoryHandle(ptr);
        }

        public bool IsCreated
        {
            get
            {
                return Ptr != IntPtr.Zero;
            }
        }

        public JobHandle Dispose(JobHandle inputDeps)
        {
            return new DisposeJob { keyHandle = this }.Schedule(dependsOn: inputDeps);
        }

        public void Dispose()
        {
            if (!IsCreated)
                return;

            sodium_free(Ptr);
            Ptr = IntPtr.Zero;
        }

        internal struct DisposeJob : IJob
        {
            public SecureMemoryHandle keyHandle;

            public void Execute()
            {
                keyHandle.Dispose();
            }
        }
    }
}
