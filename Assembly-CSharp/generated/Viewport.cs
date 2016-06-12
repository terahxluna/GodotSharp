/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Viewport : Node {
  public static readonly int RENDER_TARGET_UPDATE_DISABLED = 0;
  public static readonly int RENDER_TARGET_UPDATE_ONCE = 1;
  public static readonly int RENDER_TARGET_UPDATE_WHEN_VISIBLE = 2;
  public static readonly int RENDER_TARGET_UPDATE_ALWAYS = 3;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Viewport(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Viewport_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Viewport(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Viewport_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Viewport obj) {
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



  public void set_rect(SWIGTYPE_p_Rect2 rect) {
    GodotEnginePINVOKE.Viewport_set_rect(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Rect2 get_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.Viewport_get_rect(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_RefT_World2D_t find_world_2d() {
    SWIGTYPE_p_RefT_World2D_t ret = new SWIGTYPE_p_RefT_World2D_t(GodotEnginePINVOKE.Viewport_find_world_2d(swigCPtr), true);
    return ret;
  }

  public void set_world(SWIGTYPE_p_RefT_World_t world) {
    GodotEnginePINVOKE.Viewport_set_world(swigCPtr, SWIGTYPE_p_RefT_World_t.getCPtr(world));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_World_t get_world() {
    SWIGTYPE_p_RefT_World_t ret = new SWIGTYPE_p_RefT_World_t(GodotEnginePINVOKE.Viewport_get_world(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_RefT_World_t find_world() {
    SWIGTYPE_p_RefT_World_t ret = new SWIGTYPE_p_RefT_World_t(GodotEnginePINVOKE.Viewport_find_world(swigCPtr), true);
    return ret;
  }

  public void set_canvas_transform(Matrix32 xform) {
    GodotEnginePINVOKE.Viewport_set_canvas_transform(swigCPtr, ref xform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix32 get_canvas_transform() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.Viewport_get_canvas_transform(swigCPtr));
    return ret;
}

  public void set_global_canvas_transform(Matrix32 xform) {
    GodotEnginePINVOKE.Viewport_set_global_canvas_transform(swigCPtr, ref xform.elements);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix32 get_global_canvas_transform() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.Viewport_get_global_canvas_transform(swigCPtr));
    return ret;
}

  public Matrix32 get_final_transform() {
    Matrix32 ret = new Matrix32(GodotEnginePINVOKE.Viewport_get_final_transform(swigCPtr));
    return ret;
}

  public SWIGTYPE_p_Rect2 get_visible_rect() {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.Viewport_get_visible_rect(swigCPtr), true);
    return ret;
  }

  public void set_transparent_background(bool enable) {
    GodotEnginePINVOKE.Viewport_set_transparent_background(swigCPtr, enable);
  }

  public bool has_transparent_background() {
    bool ret = GodotEnginePINVOKE.Viewport_has_transparent_background(swigCPtr);
    return ret;
  }

  public void set_size_override(bool enable, Vector2 size, Vector2 margin) {
    GodotEnginePINVOKE.Viewport_set_size_override__SWIG_0(swigCPtr, enable, ref size, ref margin);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_size_override(bool enable, Vector2 size) {
    GodotEnginePINVOKE.Viewport_set_size_override__SWIG_1(swigCPtr, enable, ref size);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_size_override(bool enable) {
    GodotEnginePINVOKE.Viewport_set_size_override__SWIG_2(swigCPtr, enable);
  }

  public Vector2 get_size_override() {
    Vector2 ret = GodotEnginePINVOKE.Viewport_get_size_override(swigCPtr);
    return ret;
}

  public bool is_size_override_enabled() {
    bool ret = GodotEnginePINVOKE.Viewport_is_size_override_enabled(swigCPtr);
    return ret;
  }

  public void set_size_override_stretch(bool enabled) {
    GodotEnginePINVOKE.Viewport_set_size_override_stretch(swigCPtr, enabled);
  }

  public bool is_size_override_stretch_enabled() {
    bool ret = GodotEnginePINVOKE.Viewport_is_size_override_stretch_enabled(swigCPtr);
    return ret;
  }

  public void queue_screen_capture() {
    GodotEnginePINVOKE.Viewport_queue_screen_capture(swigCPtr);
  }

  public SWIGTYPE_p_Image get_screen_capture() {
    SWIGTYPE_p_Image ret = new SWIGTYPE_p_Image(GodotEnginePINVOKE.Viewport_get_screen_capture(swigCPtr), true);
    return ret;
  }

  public void set_as_render_target(bool enable) {
    GodotEnginePINVOKE.Viewport_set_as_render_target(swigCPtr, enable);
  }

  public bool is_set_as_render_target() {
    bool ret = GodotEnginePINVOKE.Viewport_is_set_as_render_target(swigCPtr);
    return ret;
  }

  public void set_render_target_vflip(bool enable) {
    GodotEnginePINVOKE.Viewport_set_render_target_vflip(swigCPtr, enable);
  }

  public bool get_render_target_vflip() {
    bool ret = GodotEnginePINVOKE.Viewport_get_render_target_vflip(swigCPtr);
    return ret;
  }

  public void set_render_target_clear_on_new_frame(bool enable) {
    GodotEnginePINVOKE.Viewport_set_render_target_clear_on_new_frame(swigCPtr, enable);
  }

  public bool get_render_target_clear_on_new_frame() {
    bool ret = GodotEnginePINVOKE.Viewport_get_render_target_clear_on_new_frame(swigCPtr);
    return ret;
  }

  public void render_target_clear() {
    GodotEnginePINVOKE.Viewport_render_target_clear(swigCPtr);
  }

  public void set_render_target_filter(bool enable) {
    GodotEnginePINVOKE.Viewport_set_render_target_filter(swigCPtr, enable);
  }

  public bool get_render_target_filter() {
    bool ret = GodotEnginePINVOKE.Viewport_get_render_target_filter(swigCPtr);
    return ret;
  }

  public void set_render_target_gen_mipmaps(bool enable) {
    GodotEnginePINVOKE.Viewport_set_render_target_gen_mipmaps(swigCPtr, enable);
  }

  public bool get_render_target_gen_mipmaps() {
    bool ret = GodotEnginePINVOKE.Viewport_get_render_target_gen_mipmaps(swigCPtr);
    return ret;
  }

  public void set_render_target_update_mode(int mode) {
    GodotEnginePINVOKE.Viewport_set_render_target_update_mode(swigCPtr, mode);
  }

  public int get_render_target_update_mode() {
    int ret = GodotEnginePINVOKE.Viewport_get_render_target_update_mode(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_RefT_RenderTargetTexture_t get_render_target_texture() {
    SWIGTYPE_p_RefT_RenderTargetTexture_t ret = new SWIGTYPE_p_RefT_RenderTargetTexture_t(GodotEnginePINVOKE.Viewport_get_render_target_texture(swigCPtr), true);
    return ret;
  }

  public void set_physics_object_picking(bool enable) {
    GodotEnginePINVOKE.Viewport_set_physics_object_picking(swigCPtr, enable);
  }

  public bool get_physics_object_picking() {
    bool ret = GodotEnginePINVOKE.Viewport_get_physics_object_picking(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_RID get_viewport() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Viewport_get_viewport(swigCPtr), true);
    return ret;
  }

  public void input(SWIGTYPE_p_InputEvent local_event) {
    GodotEnginePINVOKE.Viewport_input(swigCPtr, SWIGTYPE_p_InputEvent.getCPtr(local_event));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void unhandled_input(SWIGTYPE_p_InputEvent local_event) {
    GodotEnginePINVOKE.Viewport_unhandled_input(swigCPtr, SWIGTYPE_p_InputEvent.getCPtr(local_event));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void update_worlds() {
    GodotEnginePINVOKE.Viewport_update_worlds(swigCPtr);
  }

  public void set_use_own_world(bool enable) {
    GodotEnginePINVOKE.Viewport_set_use_own_world(swigCPtr, enable);
  }

  public bool is_using_own_world() {
    bool ret = GodotEnginePINVOKE.Viewport_is_using_own_world(swigCPtr);
    return ret;
  }

  public Camera get_camera() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Viewport_get_camera(swigCPtr);
    Camera ret = (cPtr == global::System.IntPtr.Zero) ? null : new Camera(cPtr, false);
    return ret;
  }

  public void set_as_audio_listener(bool enable) {
    GodotEnginePINVOKE.Viewport_set_as_audio_listener(swigCPtr, enable);
  }

  public bool is_audio_listener() {
    bool ret = GodotEnginePINVOKE.Viewport_is_audio_listener(swigCPtr);
    return ret;
  }

  public void set_as_audio_listener_2d(bool enable) {
    GodotEnginePINVOKE.Viewport_set_as_audio_listener_2d(swigCPtr, enable);
  }

  public bool is_audio_listener_2d() {
    bool ret = GodotEnginePINVOKE.Viewport_is_audio_listener_2d(swigCPtr);
    return ret;
  }

  public void set_render_target_to_screen_rect(SWIGTYPE_p_Rect2 rect) {
    GodotEnginePINVOKE.Viewport_set_render_target_to_screen_rect(swigCPtr, SWIGTYPE_p_Rect2.getCPtr(rect));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 get_mouse_pos() {
    Vector2 ret = GodotEnginePINVOKE.Viewport_get_mouse_pos(swigCPtr);
    return ret;
}

  public void warp_mouse(Vector2 to_pos) {
    GodotEnginePINVOKE.Viewport_warp_mouse(swigCPtr, ref to_pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool gui_has_modal_stack() {
    bool ret = GodotEnginePINVOKE.Viewport_gui_has_modal_stack(swigCPtr);
    return ret;
  }

  public Variant gui_get_drag_data() {
    Variant ret = new Variant(GodotEnginePINVOKE.Viewport_gui_get_drag_data(swigCPtr), true);
    return ret;
  }

  public void set_disable_input(bool disable) {
    GodotEnginePINVOKE.Viewport_set_disable_input(swigCPtr, disable);
  }

  public bool is_input_disabled() {
    bool ret = GodotEnginePINVOKE.Viewport_is_input_disabled(swigCPtr);
    return ret;
  }

  public Viewport() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_Viewport());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}