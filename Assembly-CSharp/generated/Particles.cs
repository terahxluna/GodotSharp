/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Particles : GeometryInstance {
  public static readonly int VAR_LIFETIME = 0;
  public static readonly int VAR_SPREAD = 1;
  public static readonly int VAR_GRAVITY = 2;
  public static readonly int VAR_LINEAR_VELOCITY = 3;
  public static readonly int VAR_ANGULAR_VELOCITY = 4;
  public static readonly int VAR_LINEAR_ACCELERATION = 5;
  public static readonly int VAR_DRAG = 6;
  public static readonly int VAR_TANGENTIAL_ACCELERATION = 7;
  public static readonly int VAR_INITIAL_SIZE = 9;
  public static readonly int VAR_FINAL_SIZE = 10;
  public static readonly int VAR_INITIAL_ANGLE = 11;
  public static readonly int VAR_HEIGHT = 12;
  public static readonly int VAR_HEIGHT_SPEED_SCALE = 13;
  public static readonly int VAR_MAX = 14;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Particles(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Particles_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Particles(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Particles_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Particles obj) {
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



  public void set_amount(int amount) {
    GodotEnginePINVOKE.Particles_set_amount(swigCPtr, amount);
  }

  public int get_amount() {
    int ret = GodotEnginePINVOKE.Particles_get_amount(swigCPtr);
    return ret;
  }

  public void set_emitting(bool enabled) {
    GodotEnginePINVOKE.Particles_set_emitting(swigCPtr, enabled);
  }

  public bool is_emitting() {
    bool ret = GodotEnginePINVOKE.Particles_is_emitting(swigCPtr);
    return ret;
  }

  public void set_visibility_aabb(SWIGTYPE_p_AABB aabb) {
    GodotEnginePINVOKE.Particles_set_visibility_aabb(swigCPtr, SWIGTYPE_p_AABB.getCPtr(aabb));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_AABB get_visibility_aabb() {
    SWIGTYPE_p_AABB ret = new SWIGTYPE_p_AABB(GodotEnginePINVOKE.Particles_get_visibility_aabb(swigCPtr), true);
    return ret;
  }

  public void set_emission_half_extents(SWIGTYPE_p_Vector3 half_extents) {
    GodotEnginePINVOKE.Particles_set_emission_half_extents(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(half_extents));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector3 get_emission_half_extents() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.Particles_get_emission_half_extents(swigCPtr), true);
    return ret;
  }

  public void set_emission_base_velocity(SWIGTYPE_p_Vector3 base_velocity) {
    GodotEnginePINVOKE.Particles_set_emission_base_velocity(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(base_velocity));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector3 get_emission_base_velocity() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.Particles_get_emission_base_velocity(swigCPtr), true);
    return ret;
  }

  public void set_emission_points(SWIGTYPE_p_Vector3Array points) {
    GodotEnginePINVOKE.Particles_set_emission_points(swigCPtr, SWIGTYPE_p_Vector3Array.getCPtr(points));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector3Array get_emission_points() {
    SWIGTYPE_p_Vector3Array ret = new SWIGTYPE_p_Vector3Array(GodotEnginePINVOKE.Particles_get_emission_points(swigCPtr), true);
    return ret;
  }

  public void set_gravity_normal(SWIGTYPE_p_Vector3 normal) {
    GodotEnginePINVOKE.Particles_set_gravity_normal(swigCPtr, SWIGTYPE_p_Vector3.getCPtr(normal));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Vector3 get_gravity_normal() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.Particles_get_gravity_normal(swigCPtr), true);
    return ret;
  }

  public void set_variable(int variable, float value) {
    GodotEnginePINVOKE.Particles_set_variable(swigCPtr, variable, value);
  }

  public float get_variable(int variable) {
    float ret = GodotEnginePINVOKE.Particles_get_variable(swigCPtr, variable);
    return ret;
  }

  public void set_randomness(int variable, float randomness) {
    GodotEnginePINVOKE.Particles_set_randomness(swigCPtr, variable, randomness);
  }

  public float get_randomness(int variable) {
    float ret = GodotEnginePINVOKE.Particles_get_randomness(swigCPtr, variable);
    return ret;
  }

  public void set_color_phase_pos(int phase, float pos) {
    GodotEnginePINVOKE.Particles_set_color_phase_pos(swigCPtr, phase, pos);
  }

  public float get_color_phase_pos(int phase) {
    float ret = GodotEnginePINVOKE.Particles_get_color_phase_pos(swigCPtr, phase);
    return ret;
  }

  public void set_color_phase_color(int phase, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.Particles_set_color_phase_color(swigCPtr, phase, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Color get_color_phase_color(int phase) {
    SWIGTYPE_p_Color ret = new SWIGTYPE_p_Color(GodotEnginePINVOKE.Particles_get_color_phase_color(swigCPtr, phase), true);
    return ret;
  }

  public void set_material(SWIGTYPE_p_RefT_Material_t material) {
    GodotEnginePINVOKE.Particles_set_material(swigCPtr, SWIGTYPE_p_RefT_Material_t.getCPtr(material));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_Material_t get_material() {
    SWIGTYPE_p_RefT_Material_t ret = new SWIGTYPE_p_RefT_Material_t(GodotEnginePINVOKE.Particles_get_material(swigCPtr), true);
    return ret;
  }

  public void set_emit_timeout(float timeout) {
    GodotEnginePINVOKE.Particles_set_emit_timeout(swigCPtr, timeout);
  }

  public float get_emit_timeout() {
    float ret = GodotEnginePINVOKE.Particles_get_emit_timeout(swigCPtr);
    return ret;
  }

  public void set_height_from_velocity(bool enable) {
    GodotEnginePINVOKE.Particles_set_height_from_velocity(swigCPtr, enable);
  }

  public bool has_height_from_velocity() {
    bool ret = GodotEnginePINVOKE.Particles_has_height_from_velocity(swigCPtr);
    return ret;
  }

  public void set_use_local_coordinates(bool enable) {
    GodotEnginePINVOKE.Particles_set_use_local_coordinates(swigCPtr, enable);
  }

  public bool is_using_local_coordinates() {
    bool ret = GodotEnginePINVOKE.Particles_is_using_local_coordinates(swigCPtr);
    return ret;
  }

  public void set_color_phases(int count) {
    GodotEnginePINVOKE.Particles_set_color_phases(swigCPtr, count);
  }

  public int get_color_phases() {
    int ret = GodotEnginePINVOKE.Particles_get_color_phases(swigCPtr);
    return ret;
  }

  public Particles() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Particles());
    }
  }

}

}
