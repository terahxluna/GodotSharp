/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class StyleBoxTexture : StyleBox {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal StyleBoxTexture(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.StyleBoxTexture_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected StyleBoxTexture(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.StyleBoxTexture_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StyleBoxTexture obj) {
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



  public void set_texture(SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.StyleBoxTexture_set_texture(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_Texture_t get_texture() {
    SWIGTYPE_p_RefT_Texture_t ret = new SWIGTYPE_p_RefT_Texture_t(GodotEnginePINVOKE.StyleBoxTexture_get_texture(swigCPtr), true);
    return ret;
  }

  public void set_margin_size(int margin, float size) {
    GodotEnginePINVOKE.StyleBoxTexture_set_margin_size(swigCPtr, margin, size);
  }

  public float get_margin_size(int margin) {
    float ret = GodotEnginePINVOKE.StyleBoxTexture_get_margin_size(swigCPtr, margin);
    return ret;
  }

  public void set_expand_margin_size(int margin, float size) {
    GodotEnginePINVOKE.StyleBoxTexture_set_expand_margin_size(swigCPtr, margin, size);
  }

  public float get_expand_margin_size(int margin) {
    float ret = GodotEnginePINVOKE.StyleBoxTexture_get_expand_margin_size(swigCPtr, margin);
    return ret;
  }

  public void set_region_rect(SWIGTYPE_p_Rect2 region) {
    GodotEnginePINVOKE.StyleBoxTexture_set_region_rect(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(region));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Rect2 get_region_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.StyleBoxTexture_get_region_rect(swigCPtr), true);
    return ret;
  }

  public void set_draw_center(bool enable) {
    GodotEnginePINVOKE.StyleBoxTexture_set_draw_center(swigCPtr, enable);
  }

  public bool get_draw_center() {
    bool ret = GodotEnginePINVOKE.StyleBoxTexture_get_draw_center(swigCPtr);
    return ret;
  }

  public StyleBoxTexture() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_StyleBoxTexture());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}