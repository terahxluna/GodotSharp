/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class SamplePlayer : Node {
  public static readonly int FILTER_NONE = 0;
  public static readonly int FILTER_LOWPASS = 1;
  public static readonly int FILTER_BANDPASS = 2;
  public static readonly int FILTER_HIPASS = 3;
  public static readonly int FILTER_NOTCH = 4;
  public static readonly int FILTER_PEAK = 5;
  public static readonly int FILTER_BANDLIMIT = 6;
  public static readonly int FILTER_LOW_SHELF = 7;
  public static readonly int FILTER_HIGH_SHELF = 8;
  public static readonly int REVERB_SMALL = 0;
  public static readonly int REVERB_MEDIUM = 1;
  public static readonly int REVERB_LARGE = 2;
  public static readonly int REVERB_HALL = 3;
  public static readonly int INVALID_VOICE_ID = -1;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal SamplePlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.SamplePlayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected SamplePlayer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.SamplePlayer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SamplePlayer obj) {
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



  public void set_sample_library(SWIGTYPE_p_RefT_SampleLibrary_t library) {
    GodotEnginePINVOKE.SamplePlayer_set_sample_library(swigCPtr, SWIGTYPE_p_RefT_SampleLibrary_t.getCPtr(library));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_SampleLibrary_t get_sample_library() {
    SWIGTYPE_p_RefT_SampleLibrary_t ret = new SWIGTYPE_p_RefT_SampleLibrary_t(GodotEnginePINVOKE.SamplePlayer_get_sample_library(swigCPtr), true);
    return ret;
  }

  public void set_polyphony(int max_voices) {
    GodotEnginePINVOKE.SamplePlayer_set_polyphony(swigCPtr, max_voices);
  }

  public int get_polyphony() {
    int ret = GodotEnginePINVOKE.SamplePlayer_get_polyphony(swigCPtr);
    return ret;
  }

  public int play(string name, bool unique) {
    int ret = GodotEnginePINVOKE.SamplePlayer_play__SWIG_0(swigCPtr, name, unique);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int play(string name) {
    int ret = GodotEnginePINVOKE.SamplePlayer_play__SWIG_1(swigCPtr, name);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void stop(int voice) {
    GodotEnginePINVOKE.SamplePlayer_stop(swigCPtr, voice);
  }

  public void stop_all() {
    GodotEnginePINVOKE.SamplePlayer_stop_all(swigCPtr);
  }

  public void set_mix_rate(int voice, int hz) {
    GodotEnginePINVOKE.SamplePlayer_set_mix_rate(swigCPtr, voice, hz);
  }

  public void set_pitch_scale(int voice, float ratio) {
    GodotEnginePINVOKE.SamplePlayer_set_pitch_scale(swigCPtr, voice, ratio);
  }

  public void set_volume(int voice, float volume) {
    GodotEnginePINVOKE.SamplePlayer_set_volume(swigCPtr, voice, volume);
  }

  public void set_volume_db(int voice, float db) {
    GodotEnginePINVOKE.SamplePlayer_set_volume_db(swigCPtr, voice, db);
  }

  public void set_pan(int voice, float pan, float depth, float height) {
    GodotEnginePINVOKE.SamplePlayer_set_pan__SWIG_0(swigCPtr, voice, pan, depth, height);
  }

  public void set_pan(int voice, float pan, float depth) {
    GodotEnginePINVOKE.SamplePlayer_set_pan__SWIG_1(swigCPtr, voice, pan, depth);
  }

  public void set_pan(int voice, float pan) {
    GodotEnginePINVOKE.SamplePlayer_set_pan__SWIG_2(swigCPtr, voice, pan);
  }

  public void set_filter(int voice, int type, float cutoff_hz, float resonance, float gain) {
    GodotEnginePINVOKE.SamplePlayer_set_filter__SWIG_0(swigCPtr, voice, type, cutoff_hz, resonance, gain);
  }

  public void set_filter(int voice, int type, float cutoff_hz, float resonance) {
    GodotEnginePINVOKE.SamplePlayer_set_filter__SWIG_1(swigCPtr, voice, type, cutoff_hz, resonance);
  }

  public void set_chorus(int voice, float send) {
    GodotEnginePINVOKE.SamplePlayer_set_chorus(swigCPtr, voice, send);
  }

  public void set_reverb(int voice, int room_type, float send) {
    GodotEnginePINVOKE.SamplePlayer_set_reverb(swigCPtr, voice, room_type, send);
  }

  public int get_mix_rate(int voice) {
    int ret = GodotEnginePINVOKE.SamplePlayer_get_mix_rate(swigCPtr, voice);
    return ret;
  }

  public float get_pitch_scale(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_pitch_scale(swigCPtr, voice);
    return ret;
  }

  public float get_volume(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_volume(swigCPtr, voice);
    return ret;
  }

  public float get_volume_db(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_volume_db(swigCPtr, voice);
    return ret;
  }

  public float get_pan(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_pan(swigCPtr, voice);
    return ret;
  }

  public float get_pan_depth(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_pan_depth(swigCPtr, voice);
    return ret;
  }

  public float get_pan_height(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_pan_height(swigCPtr, voice);
    return ret;
  }

  public int get_filter_type(int voice) {
    int ret = GodotEnginePINVOKE.SamplePlayer_get_filter_type(swigCPtr, voice);
    return ret;
  }

  public float get_filter_cutoff(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_filter_cutoff(swigCPtr, voice);
    return ret;
  }

  public float get_filter_resonance(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_filter_resonance(swigCPtr, voice);
    return ret;
  }

  public float get_filter_gain(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_filter_gain(swigCPtr, voice);
    return ret;
  }

  public float get_chorus(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_chorus(swigCPtr, voice);
    return ret;
  }

  public int get_reverb_room(int voice) {
    int ret = GodotEnginePINVOKE.SamplePlayer_get_reverb_room(swigCPtr, voice);
    return ret;
  }

  public float get_reverb(int voice) {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_reverb(swigCPtr, voice);
    return ret;
  }

  public void set_default_pitch_scale(float ratio) {
    GodotEnginePINVOKE.SamplePlayer_set_default_pitch_scale(swigCPtr, ratio);
  }

  public void set_default_volume(float volume) {
    GodotEnginePINVOKE.SamplePlayer_set_default_volume(swigCPtr, volume);
  }

  public void set_default_volume_db(float db) {
    GodotEnginePINVOKE.SamplePlayer_set_default_volume_db(swigCPtr, db);
  }

  public void set_default_pan(float pan, float depth, float height) {
    GodotEnginePINVOKE.SamplePlayer_set_default_pan__SWIG_0(swigCPtr, pan, depth, height);
  }

  public void set_default_pan(float pan, float depth) {
    GodotEnginePINVOKE.SamplePlayer_set_default_pan__SWIG_1(swigCPtr, pan, depth);
  }

  public void set_default_pan(float pan) {
    GodotEnginePINVOKE.SamplePlayer_set_default_pan__SWIG_2(swigCPtr, pan);
  }

  public void set_default_filter(int type, float cutoff_hz, float resonance, float gain) {
    GodotEnginePINVOKE.SamplePlayer_set_default_filter__SWIG_0(swigCPtr, type, cutoff_hz, resonance, gain);
  }

  public void set_default_filter(int type, float cutoff_hz, float resonance) {
    GodotEnginePINVOKE.SamplePlayer_set_default_filter__SWIG_1(swigCPtr, type, cutoff_hz, resonance);
  }

  public void set_default_chorus(float send) {
    GodotEnginePINVOKE.SamplePlayer_set_default_chorus(swigCPtr, send);
  }

  public void set_default_reverb(int room_type, float send) {
    GodotEnginePINVOKE.SamplePlayer_set_default_reverb(swigCPtr, room_type, send);
  }

  public float get_default_pitch_scale() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_pitch_scale(swigCPtr);
    return ret;
  }

  public float get_default_volume() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_volume(swigCPtr);
    return ret;
  }

  public float get_default_volume_db() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_volume_db(swigCPtr);
    return ret;
  }

  public float get_default_pan() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_pan(swigCPtr);
    return ret;
  }

  public float get_default_pan_depth() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_pan_depth(swigCPtr);
    return ret;
  }

  public float get_default_pan_height() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_pan_height(swigCPtr);
    return ret;
  }

  public int get_default_filter_type() {
    int ret = GodotEnginePINVOKE.SamplePlayer_get_default_filter_type(swigCPtr);
    return ret;
  }

  public float get_default_filter_cutoff() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_filter_cutoff(swigCPtr);
    return ret;
  }

  public float get_default_filter_resonance() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_filter_resonance(swigCPtr);
    return ret;
  }

  public float get_default_filter_gain() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_filter_gain(swigCPtr);
    return ret;
  }

  public float get_default_chorus() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_chorus(swigCPtr);
    return ret;
  }

  public int get_default_reverb_room() {
    int ret = GodotEnginePINVOKE.SamplePlayer_get_default_reverb_room(swigCPtr);
    return ret;
  }

  public float get_default_reverb() {
    float ret = GodotEnginePINVOKE.SamplePlayer_get_default_reverb(swigCPtr);
    return ret;
  }

  public bool is_active() {
    bool ret = GodotEnginePINVOKE.SamplePlayer_is_active(swigCPtr);
    return ret;
  }

  public bool is_voice_active(int voice) {
    bool ret = GodotEnginePINVOKE.SamplePlayer_is_voice_active(swigCPtr, voice);
    return ret;
  }

  public SamplePlayer() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_SamplePlayer());
    }
  }

}

}
