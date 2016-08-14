/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class BitmapFont : Font {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal BitmapFont(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.BitmapFont_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected BitmapFont(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.BitmapFont_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BitmapFont obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BitmapFont() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GodotEnginePINVOKE.delete_BitmapFont(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



  public BitmapFont() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_BitmapFont());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

  public int create_from_fnt(string path) {
    int ret = GodotEnginePINVOKE.BitmapFont_create_from_fnt(swigCPtr, path);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_height(float px) {
    GodotEnginePINVOKE.BitmapFont_set_height(swigCPtr, px);
  }

  public void set_ascent(float px) {
    GodotEnginePINVOKE.BitmapFont_set_ascent(swigCPtr, px);
  }

  public void add_kerning_pair(int char_a, int char_b, int kerning) {
    GodotEnginePINVOKE.BitmapFont_add_kerning_pair(swigCPtr, char_a, char_b, kerning);
  }

  public int get_kerning_pair(int char_a, int char_b) {
    int ret = GodotEnginePINVOKE.BitmapFont_get_kerning_pair(swigCPtr, char_a, char_b);
    return ret;
  }

  public void add_texture(Texture texture) {
    GodotEnginePINVOKE.BitmapFont_add_texture(swigCPtr, Texture.getCPtr(texture));
  }

  public void add_char(int character, int texture, Rect2 rect, Vector2 align, float advance) {
    GodotEnginePINVOKE.BitmapFont_add_char__SWIG_0(swigCPtr, character, texture, ref rect, ref align, advance);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_char(int character, int texture, Rect2 rect, Vector2 align) {
    GodotEnginePINVOKE.BitmapFont_add_char__SWIG_1(swigCPtr, character, texture, ref rect, ref align);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_char(int character, int texture, Rect2 rect) {
    GodotEnginePINVOKE.BitmapFont_add_char__SWIG_2(swigCPtr, character, texture, ref rect);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_texture_count() {
    int ret = GodotEnginePINVOKE.BitmapFont_get_texture_count(swigCPtr);
    return ret;
  }

  public Texture get_texture(int idx) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.BitmapFont_get_texture(swigCPtr, idx);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Texture ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Texture;
    return ret;
}

  public Vector2 get_char_size(int char_, int next) {
    Vector2 ret = GodotEnginePINVOKE.BitmapFont_get_char_size__SWIG_0(swigCPtr, char_, next);
    return ret;
}

  public Vector2 get_char_size(int char_) {
    Vector2 ret = GodotEnginePINVOKE.BitmapFont_get_char_size__SWIG_1(swigCPtr, char_);
    return ret;
}

  public void set_distance_field_hint(bool enable) {
    GodotEnginePINVOKE.BitmapFont_set_distance_field_hint(swigCPtr, enable);
  }

  public void clear() {
    GodotEnginePINVOKE.BitmapFont_clear(swigCPtr);
  }

  public void set_fallback(Object fallback) {
    GodotEnginePINVOKE.BitmapFont_set_fallback(swigCPtr, Object.getCPtr(fallback));
  }

  public Object get_fallback() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.BitmapFont_get_fallback(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

}

}
