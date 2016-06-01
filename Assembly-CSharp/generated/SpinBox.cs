/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class SpinBox : Range {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal SpinBox(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.SpinBox_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected SpinBox(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.SpinBox_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SpinBox obj) {
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



  public void set_suffix(string suffix) {
    GodotEnginePINVOKE.SpinBox_set_suffix(swigCPtr, suffix);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_suffix() {
    string ret = GodotEnginePINVOKE.SpinBox_get_suffix(swigCPtr);
    return ret;
  }

  public void set_prefix(string prefix) {
    GodotEnginePINVOKE.SpinBox_set_prefix(swigCPtr, prefix);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_prefix() {
    string ret = GodotEnginePINVOKE.SpinBox_get_prefix(swigCPtr);
    return ret;
  }

  public void set_editable(bool editable) {
    GodotEnginePINVOKE.SpinBox_set_editable(swigCPtr, editable);
  }

  public bool is_editable() {
    bool ret = GodotEnginePINVOKE.SpinBox_is_editable(swigCPtr);
    return ret;
  }

  public Object get_line_edit() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.SpinBox_get_line_edit(swigCPtr);
    Object ret = InternalHelpers.GetManagedObjectFor(cPtr);
    if (ret == null) {
      ret = new Object(cPtr, false);
    }
    return ret;
  }

  public SpinBox() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_SpinBox());
    }
  }

}

}
