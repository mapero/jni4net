// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system;

@net.sf.jni4net.attributes.ClrType
public class Enum extends system.ValueType implements system.IComparable, system.IFormattable, system.IConvertible {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Enum(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    protected Enum() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Object;)I")
    public native int CompareTo(system.Object obj);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;LSystem/IFormatProvider;)LSystem/String;")
    public native java.lang.String ToString(java.lang.String format, system.IFormatProvider formatProvider);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/TypeCode;")
    public native system.Enum GetTypeCode();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)Z")
    public native boolean ToBoolean(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)C")
    public native char ToChar(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/SByte;")
    public native byte ToSByte(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)B")
    public native byte ToByte(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)S")
    public native short ToInt16(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/UInt16;")
    public native short ToUInt16(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)I")
    public native int ToInt32(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/UInt32;")
    public native int ToUInt32(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)J")
    public native long ToInt64(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/UInt64;")
    public native long ToUInt64(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)F")
    public native float ToSingle(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)D")
    public native double ToDouble(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/Decimal;")
    public native system.Decimal ToDecimal(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/DateTime;")
    public native system.DateTime ToDateTime(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/IFormatProvider;)LSystem/String;")
    public native java.lang.String ToString(system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/IFormatProvider;)LSystem/Object;")
    public native system.Object ToType(system.Type conversionType, system.IFormatProvider provider);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/String;)LSystem/Object;")
    public native static system.Object Parse(system.Type enumType, java.lang.String value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/String;Z)LSystem/Object;")
    public native static system.Object Parse(system.Type enumType, java.lang.String value, boolean ignoreCase);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;)LSystem/Type;")
    public native static system.Type GetUnderlyingType(system.Type enumType);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;)LSystem/Array;")
    public native static system.Array GetValues(system.Type enumType);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/Object;)LSystem/String;")
    public native static java.lang.String GetName(system.Type enumType, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;)[LSystem/String;")
    public native static system.String[] GetNames(system.Type enumType);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/Object;)LSystem/Object;")
    public native static system.Object ToObject(system.Type enumType, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/Object;)Z")
    public native static boolean IsDefined(system.Type enumType, system.Object value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/Object;LSystem/String;)LSystem/String;")
    public native static java.lang.String Format(system.Type enumType, system.Object value, java.lang.String format);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/String;)LSystem/String;")
    public native final java.lang.String ToString(java.lang.String format);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;LSystem/SByte;)LSystem/Object;")
    public native static system.Object ToObject(system.Type enumType, byte value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;S)LSystem/Object;")
    public native static system.Object ToObject(system.Type enumType, short value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;I)LSystem/Object;")
    public native static system.Object ToObject(system.Type enumType, int value);
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;J)LSystem/Object;")
    public native static system.Object ToObject(system.Type enumType, long value);
    
    public static system.Type typeof() {
        return system.Enum.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.Enum.staticType = staticType;
    }
    //</generated-proxy>
}
