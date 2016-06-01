/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class ImmediateGeometry : GeometryInstance {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal ImmediateGeometry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.ImmediateGeometry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected ImmediateGeometry(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.ImmediateGeometry_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ImmediateGeometry obj) {
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



  public void begin(int primitive, SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.ImmediateGeometry_begin(swigCPtr, primitive, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_normal(SWIGTYPE_p_Vector3 normal) {
    GodotEnginePINVOKE.ImmediateGeometry_set_normal(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(normal));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_tangent(SWIGTYPE_p_Plane tangent) {
    GodotEnginePINVOKE.ImmediateGeometry_set_tangent(swigCPtr, SWIGTYPE_p_Plane.getCPtr(tangent));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_color(SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.ImmediateGeometry_set_color(swigCPtr, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uv(Vector2 uv) {
    GodotEnginePINVOKE.ImmediateGeometry_set_uv(swigCPtr, Vector2.getCPtr(uv));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_uv2(Vector2 uv) {
    GodotEnginePINVOKE.ImmediateGeometry_set_uv2(swigCPtr, Vector2.getCPtr(uv));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_vertex(SWIGTYPE_p_Vector3 pos) {
    GodotEnginePINVOKE.ImmediateGeometry_add_vertex(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(pos));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_sphere(int lats, int lons, float radius) {
    GodotEnginePINVOKE.ImmediateGeometry_add_sphere(swigCPtr, lats, lons, radius);
  }

  public void end() {
    GodotEnginePINVOKE.ImmediateGeometry_end(swigCPtr);
  }

  public void clear() {
    GodotEnginePINVOKE.ImmediateGeometry_clear(swigCPtr);
  }

  public ImmediateGeometry() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_ImmediateGeometry());
    }
  }

}

}
