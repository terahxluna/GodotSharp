/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class ParallaxLayer : Node2D {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal ParallaxLayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.ParallaxLayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected ParallaxLayer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.ParallaxLayer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ParallaxLayer obj) {
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



  public void set_motion_scale(Vector2 scale) {
    GodotEnginePINVOKE.ParallaxLayer_set_motion_scale(swigCPtr, Vector2.getCPtr(scale));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_motion_scale() {
    Vector2 ret = new Vector2(GodotEnginePINVOKE.ParallaxLayer_get_motion_scale(swigCPtr), true);
    return ret;
  }

  public void set_mirroring(Vector2 mirror) {
    GodotEnginePINVOKE.ParallaxLayer_set_mirroring(swigCPtr, Vector2.getCPtr(mirror));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_mirroring() {
    Vector2 ret = new Vector2(GodotEnginePINVOKE.ParallaxLayer_get_mirroring(swigCPtr), true);
    return ret;
  }

  public ParallaxLayer() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_ParallaxLayer());
    }
  }

}

}
