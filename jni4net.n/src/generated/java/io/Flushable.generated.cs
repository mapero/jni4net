//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Flushable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void flush();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Flushable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.io.@__Flushable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.io.Flushable))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.io.Flushable))]
    internal sealed partial class @__Flushable : global::java.lang.Object, global::java.io.Flushable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _flush0;
        
        protected @__Flushable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.io.@__Flushable.staticClass = @__class;
            global::java.io.@__Flushable._flush0 = @__env.GetMethodID(global::java.io.@__Flushable.staticClass, "flush", "()V");
        }
        
        public void flush() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.@__Flushable._flush0);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Flushable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "flush", "flush0", "()V"));
            return methods;
        }
        
        private static void flush0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.io.Flushable @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.io.Flushable>(@__env, @__obj);
            @__real.flush();
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.io.@__Flushable(@__env);
            }
        }
    }
    #endregion
}
