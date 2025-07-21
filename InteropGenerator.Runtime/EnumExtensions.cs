using System.Numerics;
using System.Runtime.CompilerServices;

namespace InteropGenerator.Runtime;

public static class EnumExtensions {
    /// <summary>
    /// Sets or clears the specified flag on an enum value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">The original enum value.</param>
    /// <param name="flag">The flag to set or clear.</param>
    /// <param name="enabled">If <see langword="true"/>, sets the flag; if <see langword="false"/>, clears the flag.</param>
    /// <returns>The modified enum value with the flag set or cleared.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static T WithFlag<T>(this T value, T flag, bool enabled)
        where T : unmanaged, Enum {
        return Type.GetTypeCode(Enum.GetUnderlyingType(typeof(T))) switch {
            TypeCode.Byte => WithFlag<T, byte>(value, flag, enabled),
            TypeCode.SByte => WithFlag<T, sbyte>(value, flag, enabled),
            TypeCode.Int16 => WithFlag<T, short>(value, flag, enabled),
            TypeCode.UInt16 => WithFlag<T, ushort>(value, flag, enabled),
            TypeCode.Int32 => WithFlag<T, int>(value, flag, enabled),
            TypeCode.UInt32 => WithFlag<T, uint>(value, flag, enabled),
            TypeCode.Int64 => WithFlag<T, long>(value, flag, enabled),
            TypeCode.UInt64 => WithFlag<T, ulong>(value, flag, enabled),
            _ => throw new NotSupportedException($"Unsupported enum underlying type: {typeof(T)}")
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T WithFlag<T, TU>(this T value, T flag, bool enabled)
        where T : unmanaged, Enum
        where TU : unmanaged, IBinaryInteger<TU> {
        TU val = Unsafe.As<T, TU>(ref value);
        TU flg = Unsafe.As<T, TU>(ref flag);

        val = enabled ? (val | flg) : (val & ~flg);

        return Unsafe.As<TU, T>(ref val);
    }
}
