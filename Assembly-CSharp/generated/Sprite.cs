/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Sprite : Node2D {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Sprite(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Sprite_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Sprite(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Sprite_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Sprite obj) {
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



  public void set_texture(Texture texture) {
    GodotEnginePINVOKE.Sprite_set_texture(swigCPtr, Texture.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Texture get_texture() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Sprite_get_texture(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Texture ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Texture;
    return ret;
}

  public void set_centered(bool centered) {
    GodotEnginePINVOKE.Sprite_set_centered(swigCPtr, centered);
  }

  public bool is_centered() {
    bool ret = GodotEnginePINVOKE.Sprite_is_centered(swigCPtr);
    return ret;
  }

  public void set_offset(Vector2 offset) {
    GodotEnginePINVOKE.Sprite_set_offset(swigCPtr, ref offset);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_offset() {
    Vector2 ret = GodotEnginePINVOKE.Sprite_get_offset(swigCPtr);
    return ret;
}

  public void set_flip_h(bool flip_h) {
    GodotEnginePINVOKE.Sprite_set_flip_h(swigCPtr, flip_h);
  }

  public bool is_flipped_h() {
    bool ret = GodotEnginePINVOKE.Sprite_is_flipped_h(swigCPtr);
    return ret;
  }

  public void set_flip_v(bool flip_v) {
    GodotEnginePINVOKE.Sprite_set_flip_v(swigCPtr, flip_v);
  }

  public bool is_flipped_v() {
    bool ret = GodotEnginePINVOKE.Sprite_is_flipped_v(swigCPtr);
    return ret;
  }

  public void set_region(bool enabled) {
    GodotEnginePINVOKE.Sprite_set_region(swigCPtr, enabled);
  }

  public bool is_region() {
    bool ret = GodotEnginePINVOKE.Sprite_is_region(swigCPtr);
    return ret;
  }

  public void set_region_rect(SWIGTYPE_p_Rect2 rect) {
    GodotEnginePINVOKE.Sprite_set_region_rect(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Rect2 get_region_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.Sprite_get_region_rect(swigCPtr), true);
    return ret;
  }

  public void set_frame(int frame) {
    GodotEnginePINVOKE.Sprite_set_frame(swigCPtr, frame);
  }

  public int get_frame() {
    int ret = GodotEnginePINVOKE.Sprite_get_frame(swigCPtr);
    return ret;
  }

  public void set_vframes(int vframes) {
    GodotEnginePINVOKE.Sprite_set_vframes(swigCPtr, vframes);
  }

  public int get_vframes() {
    int ret = GodotEnginePINVOKE.Sprite_get_vframes(swigCPtr);
    return ret;
  }

  public void set_hframes(int hframes) {
    GodotEnginePINVOKE.Sprite_set_hframes(swigCPtr, hframes);
  }

  public int get_hframes() {
    int ret = GodotEnginePINVOKE.Sprite_get_hframes(swigCPtr);
    return ret;
  }

  public void set_modulate(SWIGTYPE_p_Color modulate) {
    GodotEnginePINVOKE.Sprite_set_modulate(swigCPtr, SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Color get_modulate() {
    SWIGTYPE_p_Color ret = new SWIGTYPE_p_Color(GodotEnginePINVOKE.Sprite_get_modulate(swigCPtr), true);
    return ret;
  }

  public Sprite() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Sprite());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
