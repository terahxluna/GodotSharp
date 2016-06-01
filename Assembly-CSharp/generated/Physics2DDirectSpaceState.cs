/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Physics2DDirectSpaceState : Object {
  public static readonly int TYPE_MASK_STATIC_BODY = 1;
  public static readonly int TYPE_MASK_KINEMATIC_BODY = 2;
  public static readonly int TYPE_MASK_RIGID_BODY = 4;
  public static readonly int TYPE_MASK_CHARACTER_BODY = 8;
  public static readonly int TYPE_MASK_AREA = 16;
  public static readonly int TYPE_MASK_COLLISION = 15;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Physics2DDirectSpaceState(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Physics2DDirectSpaceState_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Physics2DDirectSpaceState(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Physics2DDirectSpaceState_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Physics2DDirectSpaceState obj) {
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

  internal Physics2DDirectSpaceState() {}


  public SWIGTYPE_p_Array intersect_point(Vector2 point, int max_results, SWIGTYPE_p_Array exclude, int layer_mask, int type_mask) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_point__SWIG_0(swigCPtr, Vector2.getCPtr(point), max_results, SWIGTYPE_p_Array.getCPtr(exclude), layer_mask, type_mask), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array intersect_point(Vector2 point, int max_results, SWIGTYPE_p_Array exclude, int layer_mask) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_point__SWIG_1(swigCPtr, Vector2.getCPtr(point), max_results, SWIGTYPE_p_Array.getCPtr(exclude), layer_mask), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array intersect_point(Vector2 point, int max_results, SWIGTYPE_p_Array exclude) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_point__SWIG_2(swigCPtr, Vector2.getCPtr(point), max_results, SWIGTYPE_p_Array.getCPtr(exclude)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array intersect_point(Vector2 point, int max_results) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_point__SWIG_3(swigCPtr, Vector2.getCPtr(point), max_results), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array intersect_point(Vector2 point) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_point__SWIG_4(swigCPtr, Vector2.getCPtr(point)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dictionary intersect_ray(Vector2 from, Vector2 to, SWIGTYPE_p_Array exclude, int layer_mask, int type_mask) {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_ray__SWIG_0(swigCPtr, Vector2.getCPtr(from), Vector2.getCPtr(to), SWIGTYPE_p_Array.getCPtr(exclude), layer_mask, type_mask), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dictionary intersect_ray(Vector2 from, Vector2 to, SWIGTYPE_p_Array exclude, int layer_mask) {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_ray__SWIG_1(swigCPtr, Vector2.getCPtr(from), Vector2.getCPtr(to), SWIGTYPE_p_Array.getCPtr(exclude), layer_mask), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dictionary intersect_ray(Vector2 from, Vector2 to, SWIGTYPE_p_Array exclude) {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_ray__SWIG_2(swigCPtr, Vector2.getCPtr(from), Vector2.getCPtr(to), SWIGTYPE_p_Array.getCPtr(exclude)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dictionary intersect_ray(Vector2 from, Vector2 to) {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_ray__SWIG_3(swigCPtr, Vector2.getCPtr(from), Vector2.getCPtr(to)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array intersect_shape(SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t shape, int max_results) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_shape__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t.getCPtr(shape), max_results), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array intersect_shape(SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t shape) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_intersect_shape__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t.getCPtr(shape)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array cast_motion(SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t shape) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_cast_motion(swigCPtr, SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t.getCPtr(shape)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array collide_shape(SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t shape, int max_results) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_collide_shape__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t.getCPtr(shape), max_results), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array collide_shape(SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t shape) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Physics2DDirectSpaceState_collide_shape__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t.getCPtr(shape)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dictionary get_rest_info(SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t shape) {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.Physics2DDirectSpaceState_get_rest_info(swigCPtr, SWIGTYPE_p_RefT_Physics2DShapeQueryParameters_t.getCPtr(shape)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
