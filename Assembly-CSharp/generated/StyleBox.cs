/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class StyleBox : Resource {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal StyleBox(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.StyleBox_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected StyleBox(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.StyleBox_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StyleBox obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StyleBox() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GodotEnginePINVOKE.delete_StyleBox(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal StyleBox() {}


  public bool test_mask(Vector2 point, SWIGTYPE_p_Rect2 rect) {
    bool ret = GodotEnginePINVOKE.StyleBox_test_mask(swigCPtr, ref point, SWIGTYPE_p_Rect2.getCPtr(rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_default_margin(int margin, float offset) {
    GodotEnginePINVOKE.StyleBox_set_default_margin(swigCPtr, margin, offset);
  }

  public float get_default_margin(int margin) {
    float ret = GodotEnginePINVOKE.StyleBox_get_default_margin(swigCPtr, margin);
    return ret;
  }

  public float get_margin(int margin) {
    float ret = GodotEnginePINVOKE.StyleBox_get_margin(swigCPtr, margin);
    return ret;
  }

  public Vector2 get_minimum_size() {
    Vector2 ret = GodotEnginePINVOKE.StyleBox_get_minimum_size(swigCPtr);
    return ret;
}

  public Vector2 get_center_size() {
    Vector2 ret = GodotEnginePINVOKE.StyleBox_get_center_size(swigCPtr);
    return ret;
}

  public Vector2 get_offset() {
    Vector2 ret = GodotEnginePINVOKE.StyleBox_get_offset(swigCPtr);
    return ret;
}

  public void draw(SWIGTYPE_p_RID canvas_item, SWIGTYPE_p_Rect2 rect) {
    GodotEnginePINVOKE.StyleBox_draw(swigCPtr, SWIGTYPE_p_RID.getCPtr(canvas_item), SWIGTYPE_p_Rect2.getCPtr(rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
