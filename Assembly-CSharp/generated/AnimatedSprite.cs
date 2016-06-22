/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class AnimatedSprite : Node2D {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal AnimatedSprite(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.AnimatedSprite_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected AnimatedSprite(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.AnimatedSprite_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AnimatedSprite obj) {
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



  public void set_sprite_frames(SpriteFrames sprite_frames) {
    GodotEnginePINVOKE.AnimatedSprite_set_sprite_frames(swigCPtr, SpriteFrames.getCPtr(sprite_frames));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SpriteFrames get_sprite_frames() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AnimatedSprite_get_sprite_frames(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    SpriteFrames ret = InternalHelpers.UnmanagedGetManaged(cPtr) as SpriteFrames;
    return ret;
}

  public void set_animation(string animation) {
    GodotEnginePINVOKE.AnimatedSprite_set_animation(swigCPtr, animation);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_animation() {
    string ret = GodotEnginePINVOKE.AnimatedSprite_get_animation(swigCPtr);
    return ret;
  }

  public void play(string anim) {
    GodotEnginePINVOKE.AnimatedSprite_play__SWIG_0(swigCPtr, anim);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void play() {
    GodotEnginePINVOKE.AnimatedSprite_play__SWIG_1(swigCPtr);
  }

  public void stop() {
    GodotEnginePINVOKE.AnimatedSprite_stop(swigCPtr);
  }

  public bool is_playing() {
    bool ret = GodotEnginePINVOKE.AnimatedSprite_is_playing(swigCPtr);
    return ret;
  }

  public void set_centered(bool centered) {
    GodotEnginePINVOKE.AnimatedSprite_set_centered(swigCPtr, centered);
  }

  public bool is_centered() {
    bool ret = GodotEnginePINVOKE.AnimatedSprite_is_centered(swigCPtr);
    return ret;
  }

  public void set_offset(Vector2 offset) {
    GodotEnginePINVOKE.AnimatedSprite_set_offset(swigCPtr, ref offset);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_offset() {
    Vector2 ret = GodotEnginePINVOKE.AnimatedSprite_get_offset(swigCPtr);
    return ret;
}

  public void set_flip_h(bool flip_h) {
    GodotEnginePINVOKE.AnimatedSprite_set_flip_h(swigCPtr, flip_h);
  }

  public bool is_flipped_h() {
    bool ret = GodotEnginePINVOKE.AnimatedSprite_is_flipped_h(swigCPtr);
    return ret;
  }

  public void set_flip_v(bool flip_v) {
    GodotEnginePINVOKE.AnimatedSprite_set_flip_v(swigCPtr, flip_v);
  }

  public bool is_flipped_v() {
    bool ret = GodotEnginePINVOKE.AnimatedSprite_is_flipped_v(swigCPtr);
    return ret;
  }

  public void set_frame(int frame) {
    GodotEnginePINVOKE.AnimatedSprite_set_frame(swigCPtr, frame);
  }

  public int get_frame() {
    int ret = GodotEnginePINVOKE.AnimatedSprite_get_frame(swigCPtr);
    return ret;
  }

  public void set_modulate(SWIGTYPE_p_Color modulate) {
    GodotEnginePINVOKE.AnimatedSprite_set_modulate(swigCPtr, SWIGTYPE_p_Color.getCPtr(modulate));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Color get_modulate() {
    SWIGTYPE_p_Color ret = new SWIGTYPE_p_Color(GodotEnginePINVOKE.AnimatedSprite_get_modulate(swigCPtr), true);
    return ret;
  }

  public AnimatedSprite() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_AnimatedSprite());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
