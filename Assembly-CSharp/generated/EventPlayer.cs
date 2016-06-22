/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class EventPlayer : Node {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal EventPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.EventPlayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected EventPlayer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.EventPlayer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EventPlayer obj) {
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



  public void set_stream(EventStream stream) {
    GodotEnginePINVOKE.EventPlayer_set_stream(swigCPtr, EventStream.getCPtr(stream));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public EventStream get_stream() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.EventPlayer_get_stream(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    EventStream ret = InternalHelpers.UnmanagedGetManaged(cPtr) as EventStream;
    return ret;
}

  public void play() {
    GodotEnginePINVOKE.EventPlayer_play(swigCPtr);
  }

  public void stop() {
    GodotEnginePINVOKE.EventPlayer_stop(swigCPtr);
  }

  public bool is_playing() {
    bool ret = GodotEnginePINVOKE.EventPlayer_is_playing(swigCPtr);
    return ret;
  }

  public void set_paused(bool paused) {
    GodotEnginePINVOKE.EventPlayer_set_paused(swigCPtr, paused);
  }

  public bool is_paused() {
    bool ret = GodotEnginePINVOKE.EventPlayer_is_paused(swigCPtr);
    return ret;
  }

  public void set_loop(bool enabled) {
    GodotEnginePINVOKE.EventPlayer_set_loop(swigCPtr, enabled);
  }

  public bool has_loop() {
    bool ret = GodotEnginePINVOKE.EventPlayer_has_loop(swigCPtr);
    return ret;
  }

  public void set_volume(float volume) {
    GodotEnginePINVOKE.EventPlayer_set_volume(swigCPtr, volume);
  }

  public float get_volume() {
    float ret = GodotEnginePINVOKE.EventPlayer_get_volume(swigCPtr);
    return ret;
  }

  public void set_pitch_scale(float pitch_scale) {
    GodotEnginePINVOKE.EventPlayer_set_pitch_scale(swigCPtr, pitch_scale);
  }

  public float get_pitch_scale() {
    float ret = GodotEnginePINVOKE.EventPlayer_get_pitch_scale(swigCPtr);
    return ret;
  }

  public void set_tempo_scale(float tempo_scale) {
    GodotEnginePINVOKE.EventPlayer_set_tempo_scale(swigCPtr, tempo_scale);
  }

  public float get_tempo_scale() {
    float ret = GodotEnginePINVOKE.EventPlayer_get_tempo_scale(swigCPtr);
    return ret;
  }

  public void set_volume_db(float db) {
    GodotEnginePINVOKE.EventPlayer_set_volume_db(swigCPtr, db);
  }

  public float get_volume_db() {
    float ret = GodotEnginePINVOKE.EventPlayer_get_volume_db(swigCPtr);
    return ret;
  }

  public string get_stream_name() {
    string ret = GodotEnginePINVOKE.EventPlayer_get_stream_name(swigCPtr);
    return ret;
  }

  public int get_loop_count() {
    int ret = GodotEnginePINVOKE.EventPlayer_get_loop_count(swigCPtr);
    return ret;
  }

  public float get_pos() {
    float ret = GodotEnginePINVOKE.EventPlayer_get_pos(swigCPtr);
    return ret;
  }

  public void seek_pos(float time) {
    GodotEnginePINVOKE.EventPlayer_seek_pos(swigCPtr, time);
  }

  public float get_length() {
    float ret = GodotEnginePINVOKE.EventPlayer_get_length(swigCPtr);
    return ret;
  }

  public void set_autoplay(bool enabled) {
    GodotEnginePINVOKE.EventPlayer_set_autoplay(swigCPtr, enabled);
  }

  public bool has_autoplay() {
    bool ret = GodotEnginePINVOKE.EventPlayer_has_autoplay(swigCPtr);
    return ret;
  }

  public void set_channel_volume(int channel, float channel_volume) {
    GodotEnginePINVOKE.EventPlayer_set_channel_volume(swigCPtr, channel, channel_volume);
  }

  public float get_channel_volume(int channel) {
    float ret = GodotEnginePINVOKE.EventPlayer_get_channel_volume(swigCPtr, channel);
    return ret;
  }

  public float get_channel_last_note_time(int channel) {
    float ret = GodotEnginePINVOKE.EventPlayer_get_channel_last_note_time(swigCPtr, channel);
    return ret;
  }

  public EventPlayer() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_EventPlayer());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
