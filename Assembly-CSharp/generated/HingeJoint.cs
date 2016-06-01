/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class HingeJoint : Joint {
  public static readonly int PARAM_BIAS = 0;
  public static readonly int PARAM_LIMIT_UPPER = 1;
  public static readonly int PARAM_LIMIT_LOWER = 2;
  public static readonly int PARAM_LIMIT_BIAS = 3;
  public static readonly int PARAM_LIMIT_SOFTNESS = 4;
  public static readonly int PARAM_LIMIT_RELAXATION = 5;
  public static readonly int PARAM_MOTOR_TARGET_VELOCITY = 6;
  public static readonly int PARAM_MOTOR_MAX_IMPULSE = 7;
  public static readonly int PARAM_MAX = 8;
  public static readonly int FLAG_USE_LIMIT = 0;
  public static readonly int FLAG_ENABLE_MOTOR = 1;
  public static readonly int FLAG_MAX = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal HingeJoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.HingeJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected HingeJoint(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.HingeJoint_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HingeJoint obj) {
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



  public void set_param(int param, float value) {
    GodotEnginePINVOKE.HingeJoint_set_param(swigCPtr, param, value);
  }

  public float get_param(int param) {
    float ret = GodotEnginePINVOKE.HingeJoint_get_param(swigCPtr, param);
    return ret;
  }

  public void set_flag(int flag, bool enabled) {
    GodotEnginePINVOKE.HingeJoint_set_flag(swigCPtr, flag, enabled);
  }

  public bool get_flag(int flag) {
    bool ret = GodotEnginePINVOKE.HingeJoint_get_flag(swigCPtr, flag);
    return ret;
  }

  public HingeJoint() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_HingeJoint());
    }
  }

}

}
