/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Slider : Range {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Slider(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Slider_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Slider(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Slider_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Slider obj) {
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

  internal Slider() {}


  public void set_ticks(int count) {
    GodotEnginePINVOKE.Slider_set_ticks(swigCPtr, count);
  }

  public int get_ticks() {
    int ret = GodotEnginePINVOKE.Slider_get_ticks(swigCPtr);
    return ret;
  }

  public bool get_ticks_on_borders() {
    bool ret = GodotEnginePINVOKE.Slider_get_ticks_on_borders(swigCPtr);
    return ret;
  }

  public void set_ticks_on_borders(bool ticks_on_border) {
    GodotEnginePINVOKE.Slider_set_ticks_on_borders(swigCPtr, ticks_on_border);
  }

}

}
