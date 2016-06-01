/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class SoundRoomParams : Node {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal SoundRoomParams(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.SoundRoomParams_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected SoundRoomParams(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.SoundRoomParams_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SoundRoomParams obj) {
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
    GodotEnginePINVOKE.SoundRoomParams_set_param(swigCPtr, param, value);
  }

  public float get_param(int param) {
    float ret = GodotEnginePINVOKE.SoundRoomParams_get_param(swigCPtr, param);
    return ret;
  }

  public void set_reverb_mode(int reverb_mode) {
    GodotEnginePINVOKE.SoundRoomParams_set_reverb_mode(swigCPtr, reverb_mode);
  }

  public int get_reverb_mode() {
    int ret = GodotEnginePINVOKE.SoundRoomParams_get_reverb_mode(swigCPtr);
    return ret;
  }

  public void set_force_params_to_all_sources(bool enabled) {
    GodotEnginePINVOKE.SoundRoomParams_set_force_params_to_all_sources(swigCPtr, enabled);
  }

  public bool is_forcing_params_to_all_sources() {
    bool ret = GodotEnginePINVOKE.SoundRoomParams_is_forcing_params_to_all_sources(swigCPtr);
    return ret;
  }

  public SoundRoomParams() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_SoundRoomParams());
    }
  }

}

}
