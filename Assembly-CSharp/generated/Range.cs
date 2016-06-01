/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Range : Control {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Range(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Range_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Range(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Range_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Range obj) {
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



  public float get_val() {
    float ret = GodotEnginePINVOKE.Range_get_val(swigCPtr);
    return ret;
  }

  public float get_value() {
    float ret = GodotEnginePINVOKE.Range_get_value(swigCPtr);
    return ret;
  }

  public float get_min() {
    float ret = GodotEnginePINVOKE.Range_get_min(swigCPtr);
    return ret;
  }

  public float get_max() {
    float ret = GodotEnginePINVOKE.Range_get_max(swigCPtr);
    return ret;
  }

  public float get_step() {
    float ret = GodotEnginePINVOKE.Range_get_step(swigCPtr);
    return ret;
  }

  public float get_page() {
    float ret = GodotEnginePINVOKE.Range_get_page(swigCPtr);
    return ret;
  }

  public float get_unit_value() {
    float ret = GodotEnginePINVOKE.Range_get_unit_value(swigCPtr);
    return ret;
  }

  public void set_val(float value) {
    GodotEnginePINVOKE.Range_set_val(swigCPtr, value);
  }

  public void set_value(float value) {
    GodotEnginePINVOKE.Range_set_value(swigCPtr, value);
  }

  public void set_min(float minimum) {
    GodotEnginePINVOKE.Range_set_min(swigCPtr, minimum);
  }

  public void set_max(float maximum) {
    GodotEnginePINVOKE.Range_set_max(swigCPtr, maximum);
  }

  public void set_step(float step) {
    GodotEnginePINVOKE.Range_set_step(swigCPtr, step);
  }

  public void set_page(float pagesize) {
    GodotEnginePINVOKE.Range_set_page(swigCPtr, pagesize);
  }

  public void set_unit_value(float value) {
    GodotEnginePINVOKE.Range_set_unit_value(swigCPtr, value);
  }

  public void set_rounded_values(bool enabled) {
    GodotEnginePINVOKE.Range_set_rounded_values(swigCPtr, enabled);
  }

  public bool is_rounded_values() {
    bool ret = GodotEnginePINVOKE.Range_is_rounded_values(swigCPtr);
    return ret;
  }

  public void set_exp_unit_value(bool enabled) {
    GodotEnginePINVOKE.Range_set_exp_unit_value(swigCPtr, enabled);
  }

  public bool is_unit_value_exp() {
    bool ret = GodotEnginePINVOKE.Range_is_unit_value_exp(swigCPtr);
    return ret;
  }

  public void share(Object with) {
    GodotEnginePINVOKE.Range_share(swigCPtr, Object.getCPtr(with));
  }

  public void unshare() {
    GodotEnginePINVOKE.Range_unshare(swigCPtr);
  }

  public Range() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Range());
    }
  }

}

}
