/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class AudioStreamPlayback : Reference {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal AudioStreamPlayback(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.AudioStreamPlayback_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected AudioStreamPlayback(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.AudioStreamPlayback_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AudioStreamPlayback obj) {
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

  internal AudioStreamPlayback() {}


  public void play(float from_pos_sec) {
    GodotEnginePINVOKE.AudioStreamPlayback_play__SWIG_0(swigCPtr, from_pos_sec);
  }

  public void play() {
    GodotEnginePINVOKE.AudioStreamPlayback_play__SWIG_1(swigCPtr);
  }

  public void stop() {
    GodotEnginePINVOKE.AudioStreamPlayback_stop(swigCPtr);
  }

  public bool is_playing() {
    bool ret = GodotEnginePINVOKE.AudioStreamPlayback_is_playing(swigCPtr);
    return ret;
  }

  public void set_loop(bool enabled) {
    GodotEnginePINVOKE.AudioStreamPlayback_set_loop(swigCPtr, enabled);
  }

  public bool has_loop() {
    bool ret = GodotEnginePINVOKE.AudioStreamPlayback_has_loop(swigCPtr);
    return ret;
  }

  public int get_loop_count() {
    int ret = GodotEnginePINVOKE.AudioStreamPlayback_get_loop_count(swigCPtr);
    return ret;
  }

  public void seek_pos(float pos) {
    GodotEnginePINVOKE.AudioStreamPlayback_seek_pos(swigCPtr, pos);
  }

  public float get_pos() {
    float ret = GodotEnginePINVOKE.AudioStreamPlayback_get_pos(swigCPtr);
    return ret;
  }

  public float get_length() {
    float ret = GodotEnginePINVOKE.AudioStreamPlayback_get_length(swigCPtr);
    return ret;
  }

  public int get_channels() {
    int ret = GodotEnginePINVOKE.AudioStreamPlayback_get_channels(swigCPtr);
    return ret;
  }

  public int get_mix_rate() {
    int ret = GodotEnginePINVOKE.AudioStreamPlayback_get_mix_rate(swigCPtr);
    return ret;
  }

  public int get_minimum_buffer_size() {
    int ret = GodotEnginePINVOKE.AudioStreamPlayback_get_minimum_buffer_size(swigCPtr);
    return ret;
  }

}

}