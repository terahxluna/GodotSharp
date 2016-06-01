/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Geometry : Object {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Geometry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Geometry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Geometry(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Geometry_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Geometry obj) {
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

  internal Geometry() {}


  public SWIGTYPE_p_Array build_box_planes(SWIGTYPE_p_Vector3 extents) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Geometry_build_box_planes(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(extents)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Array build_cylinder_planes(float radius, float height, int sides, int axis) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Geometry_build_cylinder_planes__SWIG_0(swigCPtr, radius, height, sides, axis), true);
    return ret;
  }

  public SWIGTYPE_p_Array build_cylinder_planes(float radius, float height, int sides) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Geometry_build_cylinder_planes__SWIG_1(swigCPtr, radius, height, sides), true);
    return ret;
  }

  public SWIGTYPE_p_Array build_capsule_planes(float radius, float height, int sides, int lats, int axis) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Geometry_build_capsule_planes__SWIG_0(swigCPtr, radius, height, sides, lats, axis), true);
    return ret;
  }

  public SWIGTYPE_p_Array build_capsule_planes(float radius, float height, int sides, int lats) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.Geometry_build_capsule_planes__SWIG_1(swigCPtr, radius, height, sides, lats), true);
    return ret;
  }

  public float segment_intersects_circle(Vector2 segment_from, Vector2 segment_to, Vector2 circle_pos, float circle_radius) {
    float ret = GodotEnginePINVOKE.Geometry_segment_intersects_circle(swigCPtr, Vector2.getCPtr(segment_from), Vector2.getCPtr(segment_to), Vector2.getCPtr(circle_pos), circle_radius);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void segment_intersects_segment_2d(Vector2 from_a, Vector2 to_a, Vector2 from_b, Vector2 to_b) {
    GodotEnginePINVOKE.Geometry_segment_intersects_segment_2d(swigCPtr, Vector2.getCPtr(from_a), Vector2.getCPtr(to_a), Vector2.getCPtr(from_b), Vector2.getCPtr(to_b));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector2Array get_closest_points_between_segments_2d(Vector2 p1, Vector2 q1, Vector2 p2, Vector2 q2) {
    SWIGTYPE_p_Vector2Array ret = new SWIGTYPE_p_Vector2Array(GodotEnginePINVOKE.Geometry_get_closest_points_between_segments_2d(swigCPtr, Vector2.getCPtr(p1), Vector2.getCPtr(q1), Vector2.getCPtr(p2), Vector2.getCPtr(q2)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Vector3Array get_closest_points_between_segments(SWIGTYPE_p_Vector3 p1, SWIGTYPE_p_Vector3 p2, SWIGTYPE_p_Vector3 q1, SWIGTYPE_p_Vector3 q2) {
    SWIGTYPE_p_Vector3Array ret = new SWIGTYPE_p_Vector3Array(GodotEnginePINVOKE.Geometry_get_closest_points_between_segments(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(p1), SWIGTYPE_p_Vector3.getCPtr(p2), SWIGTYPE_p_Vector3.getCPtr(q1), SWIGTYPE_p_Vector3.getCPtr(q2)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Vector3 get_closest_point_to_segment(SWIGTYPE_p_Vector3 point, SWIGTYPE_p_Vector3 s1, SWIGTYPE_p_Vector3 s2) {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.Geometry_get_closest_point_to_segment(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(point), SWIGTYPE_p_Vector3.getCPtr(s1), SWIGTYPE_p_Vector3.getCPtr(s2)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_uv84_normal_bit(SWIGTYPE_p_Vector3 normal) {
    int ret = GodotEnginePINVOKE.Geometry_get_uv84_normal_bit(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(normal));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ray_intersects_triangle(SWIGTYPE_p_Vector3 from, SWIGTYPE_p_Vector3 dir, SWIGTYPE_p_Vector3 a, SWIGTYPE_p_Vector3 b, SWIGTYPE_p_Vector3 c) {
    GodotEnginePINVOKE.Geometry_ray_intersects_triangle(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(from), SWIGTYPE_p_Vector3.getCPtr(dir), SWIGTYPE_p_Vector3.getCPtr(a), SWIGTYPE_p_Vector3.getCPtr(b), SWIGTYPE_p_Vector3.getCPtr(c));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void segment_intersects_triangle(SWIGTYPE_p_Vector3 from, SWIGTYPE_p_Vector3 to, SWIGTYPE_p_Vector3 a, SWIGTYPE_p_Vector3 b, SWIGTYPE_p_Vector3 c) {
    GodotEnginePINVOKE.Geometry_segment_intersects_triangle(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(from), SWIGTYPE_p_Vector3.getCPtr(to), SWIGTYPE_p_Vector3.getCPtr(a), SWIGTYPE_p_Vector3.getCPtr(b), SWIGTYPE_p_Vector3.getCPtr(c));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector3Array segment_intersects_sphere(SWIGTYPE_p_Vector3 from, SWIGTYPE_p_Vector3 to, SWIGTYPE_p_Vector3 spos, float sradius) {
    SWIGTYPE_p_Vector3Array ret = new SWIGTYPE_p_Vector3Array(GodotEnginePINVOKE.Geometry_segment_intersects_sphere(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(from), SWIGTYPE_p_Vector3.getCPtr(to), SWIGTYPE_p_Vector3.getCPtr(spos), sradius), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Vector3Array segment_intersects_cylinder(SWIGTYPE_p_Vector3 from, SWIGTYPE_p_Vector3 to, float height, float radius) {
    SWIGTYPE_p_Vector3Array ret = new SWIGTYPE_p_Vector3Array(GodotEnginePINVOKE.Geometry_segment_intersects_cylinder(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(from), SWIGTYPE_p_Vector3.getCPtr(to), height, radius), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Vector3Array segment_intersects_convex(SWIGTYPE_p_Vector3 from, SWIGTYPE_p_Vector3 to, SWIGTYPE_p_Array planes) {
    SWIGTYPE_p_Vector3Array ret = new SWIGTYPE_p_Vector3Array(GodotEnginePINVOKE.Geometry_segment_intersects_convex(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(from), SWIGTYPE_p_Vector3.getCPtr(to), SWIGTYPE_p_Array.getCPtr(planes)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool point_is_inside_triangle(Vector2 point, Vector2 a, Vector2 b, Vector2 c) {
    bool ret = GodotEnginePINVOKE.Geometry_point_is_inside_triangle(swigCPtr, Vector2.getCPtr(point), Vector2.getCPtr(a), Vector2.getCPtr(b), Vector2.getCPtr(c));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_IntArray triangulate_polygon(SWIGTYPE_p_Vector2Array polygon) {
    SWIGTYPE_p_IntArray ret = new SWIGTYPE_p_IntArray(GodotEnginePINVOKE.Geometry_triangulate_polygon(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(polygon)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dictionary make_atlas(SWIGTYPE_p_Vector2Array sizes) {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.Geometry_make_atlas(swigCPtr, SWIGTYPE_p_Vector2Array.getCPtr(sizes)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
