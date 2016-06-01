/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class SpatialStreamPlayer : SpatialPlayer {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal SpatialStreamPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.SpatialStreamPlayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected SpatialStreamPlayer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.SpatialStreamPlayer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SpatialStreamPlayer obj) {
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



  public void set_stream(SWIGTYPE_p_RefT_AudioStream_t stream) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_stream(swigCPtr, SWIGTYPE_p_RefT_AudioStream_t.getCPtr(stream));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_AudioStream_t get_stream() {
    SWIGTYPE_p_RefT_AudioStream_t ret = new SWIGTYPE_p_RefT_AudioStream_t(GodotEnginePINVOKE.SpatialStreamPlayer_get_stream(swigCPtr), true);
    return ret;
  }

  public void play(float offset) {
    GodotEnginePINVOKE.SpatialStreamPlayer_play__SWIG_0(swigCPtr, offset);
  }

  public void play() {
    GodotEnginePINVOKE.SpatialStreamPlayer_play__SWIG_1(swigCPtr);
  }

  public void stop() {
    GodotEnginePINVOKE.SpatialStreamPlayer_stop(swigCPtr);
  }

  public bool is_playing() {
    bool ret = GodotEnginePINVOKE.SpatialStreamPlayer_is_playing(swigCPtr);
    return ret;
  }

  public void set_paused(bool paused) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_paused(swigCPtr, paused);
  }

  public bool is_paused() {
    bool ret = GodotEnginePINVOKE.SpatialStreamPlayer_is_paused(swigCPtr);
    return ret;
  }

  public void set_loop(bool enabled) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_loop(swigCPtr, enabled);
  }

  public bool has_loop() {
    bool ret = GodotEnginePINVOKE.SpatialStreamPlayer_has_loop(swigCPtr);
    return ret;
  }

  public void set_volume(float volume) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_volume(swigCPtr, volume);
  }

  public float get_volume() {
    float ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_volume(swigCPtr);
    return ret;
  }

  public void set_volume_db(float db) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_volume_db(swigCPtr, db);
  }

  public float get_volume_db() {
    float ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_volume_db(swigCPtr);
    return ret;
  }

  public void set_buffering_msec(int msec) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_buffering_msec(swigCPtr, msec);
  }

  public int get_buffering_msec() {
    int ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_buffering_msec(swigCPtr);
    return ret;
  }

  public void set_loop_restart_time(float secs) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_loop_restart_time(swigCPtr, secs);
  }

  public float get_loop_restart_time() {
    float ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_loop_restart_time(swigCPtr);
    return ret;
  }

  public string get_stream_name() {
    string ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_stream_name(swigCPtr);
    return ret;
  }

  public int get_loop_count() {
    int ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_loop_count(swigCPtr);
    return ret;
  }

  public float get_pos() {
    float ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_pos(swigCPtr);
    return ret;
  }

  public void seek_pos(float time) {
    GodotEnginePINVOKE.SpatialStreamPlayer_seek_pos(swigCPtr, time);
  }

  public void set_autoplay(bool enabled) {
    GodotEnginePINVOKE.SpatialStreamPlayer_set_autoplay(swigCPtr, enabled);
  }

  public bool has_autoplay() {
    bool ret = GodotEnginePINVOKE.SpatialStreamPlayer_has_autoplay(swigCPtr);
    return ret;
  }

  public float get_length() {
    float ret = GodotEnginePINVOKE.SpatialStreamPlayer_get_length(swigCPtr);
    return ret;
  }

  public SpatialStreamPlayer() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_SpatialStreamPlayer());
    }
  }

}

}
