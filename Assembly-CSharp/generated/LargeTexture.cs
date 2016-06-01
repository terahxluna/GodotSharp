/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class LargeTexture : Texture {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal LargeTexture(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.LargeTexture_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected LargeTexture(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.LargeTexture_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LargeTexture obj) {
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



  public int add_piece(Vector2 ofs, SWIGTYPE_p_RefT_Texture_t texture) {
    int ret = GodotEnginePINVOKE.LargeTexture_add_piece(swigCPtr, Vector2.getCPtr(ofs), SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_piece_offset(int idx, Vector2 ofs) {
    GodotEnginePINVOKE.LargeTexture_set_piece_offset(swigCPtr, idx, Vector2.getCPtr(ofs));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_piece_texture(int idx, SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.LargeTexture_set_piece_texture(swigCPtr, idx, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_size(Vector2 size) {
    GodotEnginePINVOKE.LargeTexture_set_size(swigCPtr, Vector2.getCPtr(size));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    GodotEnginePINVOKE.LargeTexture_clear(swigCPtr);
  }

  public int get_piece_count() {
    int ret = GodotEnginePINVOKE.LargeTexture_get_piece_count(swigCPtr);
    return ret;
  }

  public Vector2 get_piece_offset(int idx) {
    Vector2 ret = new Vector2(GodotEnginePINVOKE.LargeTexture_get_piece_offset(swigCPtr, idx), true);
    return ret;
  }

  public SWIGTYPE_p_RefT_Texture_t get_piece_texture(int idx) {
    SWIGTYPE_p_RefT_Texture_t ret = new SWIGTYPE_p_RefT_Texture_t(GodotEnginePINVOKE.LargeTexture_get_piece_texture(swigCPtr, idx), true);
    return ret;
  }

  public LargeTexture() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_LargeTexture());
    }
  }

}

}
