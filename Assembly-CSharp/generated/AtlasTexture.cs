/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class AtlasTexture : Texture {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal AtlasTexture(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.AtlasTexture_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected AtlasTexture(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.AtlasTexture_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AtlasTexture obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AtlasTexture() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GodotEnginePINVOKE.delete_AtlasTexture(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



  public void set_atlas(Texture atlas) {
    GodotEnginePINVOKE.AtlasTexture_set_atlas(swigCPtr, Texture.getCPtr(atlas));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Texture get_atlas() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AtlasTexture_get_atlas(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Texture ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Texture;
    return ret;
}

  public void set_region(SWIGTYPE_p_Rect2 region) {
    GodotEnginePINVOKE.AtlasTexture_set_region(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(region));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Rect2 get_region() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.AtlasTexture_get_region(swigCPtr), true);
    return ret;
  }

  public void set_margin(SWIGTYPE_p_Rect2 margin) {
    GodotEnginePINVOKE.AtlasTexture_set_margin(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(margin));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Rect2 get_margin() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.AtlasTexture_get_margin(swigCPtr), true);
    return ret;
  }

  public AtlasTexture() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_AtlasTexture());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
