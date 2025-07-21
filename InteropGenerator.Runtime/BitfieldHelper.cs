using System.Numerics;
using System.Runtime.CompilerServices;

namespace InteropGenerator.Runtime;

public static class BitfieldHelper {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T GetBits<T>(T value, int shift, T mask)
        where T : unmanaged, IBinaryInteger<T> {
        return (value >> shift) & mask;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T SetBits<T>(T value, int shift, T mask, T newValue)
        where T : unmanaged, IBinaryInteger<T> {
        return (value & ~(mask << shift)) | ((newValue & mask) << shift);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void SetBits<T>(ref T value, int shift, T mask, T newValue)
        where T : unmanaged, IBinaryInteger<T> {
        value = (value & ~(mask << shift)) | ((newValue & mask) << shift);
    }
}
