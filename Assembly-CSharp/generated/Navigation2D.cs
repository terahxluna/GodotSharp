/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Navigation2D : Node2D {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Navigation2D(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Navigation2D_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Navigation2D(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Navigation2D_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Navigation2D obj) {
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



  public Navigation2D() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Navigation2D());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

  public int navpoly_create(NavigationPolygon mesh, Matrix32 xform, Object owner) {
    int ret = GodotEnginePINVOKE.Navigation2D_navpoly_create__SWIG_0(swigCPtr, NavigationPolygon.getCPtr(mesh), ref xform, Object.getCPtr(owner));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int navpoly_create(NavigationPolygon mesh, Matrix32 xform) {
    int ret = GodotEnginePINVOKE.Navigation2D_navpoly_create__SWIG_1(swigCPtr, NavigationPolygon.getCPtr(mesh), ref xform);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void navpoly_set_transform(int id, Matrix32 xform) {
    GodotEnginePINVOKE.Navigation2D_navpoly_set_transform(swigCPtr, id, ref xform);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void navpoly_remove(int id) {
    GodotEnginePINVOKE.Navigation2D_navpoly_remove(swigCPtr, id);
  }

  public SWIGTYPE_p_Vector2Array get_simple_path(Vector2 start, Vector2 end, bool optimize) {
    SWIGTYPE_p_Vector2Array ret = new SWIGTYPE_p_Vector2Array(GodotEnginePINVOKE.Navigation2D_get_simple_path__SWIG_0(swigCPtr, ref start, ref end, optimize), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Vector2Array get_simple_path(Vector2 start, Vector2 end) {
    SWIGTYPE_p_Vector2Array ret = new SWIGTYPE_p_Vector2Array(GodotEnginePINVOKE.Navigation2D_get_simple_path__SWIG_1(swigCPtr, ref start, ref end), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2 get_closest_point(Vector2 to_point) {
    Vector2 ret = GodotEnginePINVOKE.Navigation2D_get_closest_point(swigCPtr, ref to_point);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
}

  public Object get_closest_point_owner(Vector2 to_point) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Navigation2D_get_closest_point_owner(swigCPtr, ref to_point);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
