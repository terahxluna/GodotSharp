/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Timer : Node {
  public static readonly int TIMER_PROCESS_FIXED = 0;
  public static readonly int TIMER_PROCESS_IDLE = 1;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Timer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Timer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Timer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Timer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Timer obj) {
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



  public void set_wait_time(float time_sec) {
    GodotEnginePINVOKE.Timer_set_wait_time(swigCPtr, time_sec);
  }

  public float get_wait_time() {
    float ret = GodotEnginePINVOKE.Timer_get_wait_time(swigCPtr);
    return ret;
  }

  public void set_one_shot(bool enable) {
    GodotEnginePINVOKE.Timer_set_one_shot(swigCPtr, enable);
  }

  public bool is_one_shot() {
    bool ret = GodotEnginePINVOKE.Timer_is_one_shot(swigCPtr);
    return ret;
  }

  public void set_autostart(bool enable) {
    GodotEnginePINVOKE.Timer_set_autostart(swigCPtr, enable);
  }

  public bool has_autostart() {
    bool ret = GodotEnginePINVOKE.Timer_has_autostart(swigCPtr);
    return ret;
  }

  public void start() {
    GodotEnginePINVOKE.Timer_start(swigCPtr);
  }

  public void stop() {
    GodotEnginePINVOKE.Timer_stop(swigCPtr);
  }

  public void set_active(bool active) {
    GodotEnginePINVOKE.Timer_set_active(swigCPtr, active);
  }

  public bool is_active() {
    bool ret = GodotEnginePINVOKE.Timer_is_active(swigCPtr);
    return ret;
  }

  public float get_time_left() {
    float ret = GodotEnginePINVOKE.Timer_get_time_left(swigCPtr);
    return ret;
  }

  public void set_timer_process_mode(int mode) {
    GodotEnginePINVOKE.Timer_set_timer_process_mode(swigCPtr, mode);
  }

  public int get_timer_process_mode() {
    int ret = GodotEnginePINVOKE.Timer_get_timer_process_mode(swigCPtr);
    return ret;
  }

  public Timer() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Timer());
    }
  }

}

}
