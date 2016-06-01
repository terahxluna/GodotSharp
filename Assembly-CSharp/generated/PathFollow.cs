/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class PathFollow : Spatial {
  public static readonly int ROTATION_NONE = 0;
  public static readonly int ROTATION_Y = 1;
  public static readonly int ROTATION_XY = 2;
  public static readonly int ROTATION_XYZ = 3;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal PathFollow(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.PathFollow_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected PathFollow(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.PathFollow_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PathFollow obj) {
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



  public void set_offset(float offset) {
    GodotEnginePINVOKE.PathFollow_set_offset(swigCPtr, offset);
  }

  public float get_offset() {
    float ret = GodotEnginePINVOKE.PathFollow_get_offset(swigCPtr);
    return ret;
  }

  public void set_h_offset(float h_offset) {
    GodotEnginePINVOKE.PathFollow_set_h_offset(swigCPtr, h_offset);
  }

  public float get_h_offset() {
    float ret = GodotEnginePINVOKE.PathFollow_get_h_offset(swigCPtr);
    return ret;
  }

  public void set_v_offset(float v_offset) {
    GodotEnginePINVOKE.PathFollow_set_v_offset(swigCPtr, v_offset);
  }

  public float get_v_offset() {
    float ret = GodotEnginePINVOKE.PathFollow_get_v_offset(swigCPtr);
    return ret;
  }

  public void set_unit_offset(float unit_offset) {
    GodotEnginePINVOKE.PathFollow_set_unit_offset(swigCPtr, unit_offset);
  }

  public float get_unit_offset() {
    float ret = GodotEnginePINVOKE.PathFollow_get_unit_offset(swigCPtr);
    return ret;
  }

  public void set_rotation_mode(int rotation_mode) {
    GodotEnginePINVOKE.PathFollow_set_rotation_mode(swigCPtr, rotation_mode);
  }

  public int get_rotation_mode() {
    int ret = GodotEnginePINVOKE.PathFollow_get_rotation_mode(swigCPtr);
    return ret;
  }

  public void set_cubic_interpolation(bool enable) {
    GodotEnginePINVOKE.PathFollow_set_cubic_interpolation(swigCPtr, enable);
  }

  public bool get_cubic_interpolation() {
    bool ret = GodotEnginePINVOKE.PathFollow_get_cubic_interpolation(swigCPtr);
    return ret;
  }

  public void set_loop(bool loop) {
    GodotEnginePINVOKE.PathFollow_set_loop(swigCPtr, loop);
  }

  public bool has_loop() {
    bool ret = GodotEnginePINVOKE.PathFollow_has_loop(swigCPtr);
    return ret;
  }

  public PathFollow() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_PathFollow());
    }
  }

}

}
