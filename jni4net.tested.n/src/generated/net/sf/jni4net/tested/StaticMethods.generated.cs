//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    public unsafe partial class StaticMethods_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__StaticMethods.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.StaticMethods))]
    internal sealed unsafe partial class @__StaticMethods : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__StaticMethods(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::net.sf.jni4net.tested.@__StaticMethods.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__StaticMethods);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "add", "add0", "(II)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorStaticMethods0", "__ctorStaticMethods0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            return methods;
        }
        
        private static int add0(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, int a, int b) {
            // (II)I
            // (II)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.tested.StaticMethods.add(a, b);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void @__ctorStaticMethods0(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::net.sf.jni4net.tested.StaticMethods real = new global::net.sf.jni4net.tested.StaticMethods();
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::net.sf.jni4net.tested.@__StaticMethods(env);
            }
        }
    }
    #endregion
}
