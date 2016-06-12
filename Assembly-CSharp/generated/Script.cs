/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Script : Resource {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Script(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Script_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Script(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Script_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Script obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal Script() {}


  public bool can_instance() {
    bool ret = GodotEnginePINVOKE.Script_can_instance(swigCPtr);
    return ret;
  }

  public bool instance_has(Object base_object) {
    bool ret = GodotEnginePINVOKE.Script_instance_has(swigCPtr, Object.getCPtr(base_object));
    return ret;
  }

  public bool has_source_code() {
    bool ret = GodotEnginePINVOKE.Script_has_source_code(swigCPtr);
    return ret;
  }

  public string get_source_code() {
    string ret = GodotEnginePINVOKE.Script_get_source_code(swigCPtr);
    return ret;
  }

  public void set_source_code(string source) {
    GodotEnginePINVOKE.Script_set_source_code(swigCPtr, source);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int reload(bool keep_state) {
    int ret = GodotEnginePINVOKE.Script_reload__SWIG_0(swigCPtr, keep_state);
    return ret;
  }

  public int reload() {
    int ret = GodotEnginePINVOKE.Script_reload__SWIG_1(swigCPtr);
    return ret;
  }

}

}