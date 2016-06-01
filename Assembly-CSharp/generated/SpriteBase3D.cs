/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class SpriteBase3D : GeometryInstance {
  public static readonly int FLAG_TRANSPARENT = 0;
  public static readonly int FLAG_SHADED = 1;
  public static readonly int FLAG_MAX = 2;
  public static readonly int ALPHA_CUT_DISABLED = 0;
  public static readonly int ALPHA_CUT_DISCARD = 1;
  public static readonly int ALPHA_CUT_OPAQUE_PREPASS = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal SpriteBase3D(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.SpriteBase3D_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected SpriteBase3D(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.SpriteBase3D_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SpriteBase3D obj) {
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

  internal SpriteBase3D() {}


  public void set_centered(bool centered) {
    GodotEnginePINVOKE.SpriteBase3D_set_centered(swigCPtr, centered);
  }

  public bool is_centered() {
    bool ret = GodotEnginePINVOKE.SpriteBase3D_is_centered(swigCPtr);
    return ret;
  }

  public void set_offset(Vector2 offset) {
    GodotEnginePINVOKE.SpriteBase3D_set_offset(swigCPtr, Vector2.getCPtr(offset));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_offset() {
    Vector2 ret = new Vector2(GodotEnginePINVOKE.SpriteBase3D_get_offset(swigCPtr), true);
    return ret;
  }

  public void set_flip_h(bool flip_h) {
    GodotEnginePINVOKE.SpriteBase3D_set_flip_h(swigCPtr, flip_h);
  }

  public bool is_flipped_h() {
    bool ret = GodotEnginePINVOKE.SpriteBase3D_is_flipped_h(swigCPtr);
    return ret;
  }

  public void set_flip_v(bool flip_v) {
    GodotEnginePINVOKE.SpriteBase3D_set_flip_v(swigCPtr, flip_v);
  }

  public bool is_flipped_v() {
    bool ret = GodotEnginePINVOKE.SpriteBase3D_is_flipped_v(swigCPtr);
    return ret;
  }

  public void set_modulate(SWIGTYPE_p_Color modulate) {
    GodotEnginePINVOKE.SpriteBase3D_set_modulate(swigCPtr, SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Color get_modulate() {
    SWIGTYPE_p_Color ret = new SWIGTYPE_p_Color(GodotEnginePINVOKE.SpriteBase3D_get_modulate(swigCPtr), true);
    return ret;
  }

  public void set_opacity(float opacity) {
    GodotEnginePINVOKE.SpriteBase3D_set_opacity(swigCPtr, opacity);
  }

  public float get_opacity() {
    float ret = GodotEnginePINVOKE.SpriteBase3D_get_opacity(swigCPtr);
    return ret;
  }

  public void set_pixel_size(float pixel_size) {
    GodotEnginePINVOKE.SpriteBase3D_set_pixel_size(swigCPtr, pixel_size);
  }

  public float get_pixel_size() {
    float ret = GodotEnginePINVOKE.SpriteBase3D_get_pixel_size(swigCPtr);
    return ret;
  }

  public void set_axis(int axis) {
    GodotEnginePINVOKE.SpriteBase3D_set_axis(swigCPtr, axis);
  }

  public int get_axis() {
    int ret = GodotEnginePINVOKE.SpriteBase3D_get_axis(swigCPtr);
    return ret;
  }

  public void set_draw_flag(int flag, bool enabled) {
    GodotEnginePINVOKE.SpriteBase3D_set_draw_flag(swigCPtr, flag, enabled);
  }

  public bool get_draw_flag(int flag) {
    bool ret = GodotEnginePINVOKE.SpriteBase3D_get_draw_flag(swigCPtr, flag);
    return ret;
  }

  public void set_alpha_cut_mode(int mode) {
    GodotEnginePINVOKE.SpriteBase3D_set_alpha_cut_mode(swigCPtr, mode);
  }

  public int get_alpha_cut_mode() {
    int ret = GodotEnginePINVOKE.SpriteBase3D_get_alpha_cut_mode(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Rect2 get_item_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.SpriteBase3D_get_item_rect(swigCPtr), true);
    return ret;
  }

}

}
