/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class SceneTree : MainLoop {
  public static readonly int GROUP_CALL_DEFAULT = 0;
  public static readonly int GROUP_CALL_REVERSE = 1;
  public static readonly int GROUP_CALL_REALTIME = 2;
  public static readonly int GROUP_CALL_UNIQUE = 4;
  public static readonly int STRETCH_MODE_DISABLED = 0;
  public static readonly int STRETCH_MODE_2D = 1;
  public static readonly int STRETCH_MODE_VIEWPORT = 2;
  public static readonly int STRETCH_ASPECT_IGNORE = 0;
  public static readonly int STRETCH_ASPECT_KEEP = 1;
  public static readonly int STRETCH_ASPECT_KEEP_WIDTH = 2;
  public static readonly int STRETCH_ASPECT_KEEP_HEIGHT = 3;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal SceneTree(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.SceneTree_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected SceneTree(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.SceneTree_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SceneTree obj) {
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



  public void notify_group(int call_flags, string group, int notification) {
    GodotEnginePINVOKE.SceneTree_notify_group(swigCPtr, call_flags, group, notification);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_group(int call_flags, string group, string property, Variant value) {
    GodotEnginePINVOKE.SceneTree_set_group(swigCPtr, call_flags, group, property, Variant.getCPtr(value));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Array get_nodes_in_group(string group) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.SceneTree_get_nodes_in_group(swigCPtr, group), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Viewport get_root() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.SceneTree_get_root(swigCPtr);
    Viewport ret = (cPtr == global::System.IntPtr.Zero) ? null : new Viewport(cPtr, false);
    return ret;
  }

  public bool has_group(string name) {
    bool ret = GodotEnginePINVOKE.SceneTree_has_group(swigCPtr, name);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_auto_accept_quit(bool enabled) {
    GodotEnginePINVOKE.SceneTree_set_auto_accept_quit(swigCPtr, enabled);
  }

  public void set_editor_hint(bool enable) {
    GodotEnginePINVOKE.SceneTree_set_editor_hint(swigCPtr, enable);
  }

  public bool is_editor_hint() {
    bool ret = GodotEnginePINVOKE.SceneTree_is_editor_hint(swigCPtr);
    return ret;
  }

  public void set_debug_collisions_hint(bool enable) {
    GodotEnginePINVOKE.SceneTree_set_debug_collisions_hint(swigCPtr, enable);
  }

  public bool is_debugging_collisions_hint() {
    bool ret = GodotEnginePINVOKE.SceneTree_is_debugging_collisions_hint(swigCPtr);
    return ret;
  }

  public void set_debug_navigation_hint(bool enable) {
    GodotEnginePINVOKE.SceneTree_set_debug_navigation_hint(swigCPtr, enable);
  }

  public bool is_debugging_navigation_hint() {
    bool ret = GodotEnginePINVOKE.SceneTree_is_debugging_navigation_hint(swigCPtr);
    return ret;
  }

  public void set_edited_scene_root(Object scene) {
    GodotEnginePINVOKE.SceneTree_set_edited_scene_root(swigCPtr, Object.getCPtr(scene));
  }

  public Object get_edited_scene_root() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.SceneTree_get_edited_scene_root(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public void set_pause(bool enable) {
    GodotEnginePINVOKE.SceneTree_set_pause(swigCPtr, enable);
  }

  public bool is_paused() {
    bool ret = GodotEnginePINVOKE.SceneTree_is_paused(swigCPtr);
    return ret;
  }

  public void set_input_as_handled() {
    GodotEnginePINVOKE.SceneTree_set_input_as_handled(swigCPtr);
  }

  public int get_node_count() {
    int ret = GodotEnginePINVOKE.SceneTree_get_node_count(swigCPtr);
    return ret;
  }

  public int get_frame() {
    int ret = GodotEnginePINVOKE.SceneTree_get_frame(swigCPtr);
    return ret;
  }

  public void quit() {
    GodotEnginePINVOKE.SceneTree_quit(swigCPtr);
  }

  public void set_screen_stretch(int mode, int aspect, Vector2 minsize) {
    GodotEnginePINVOKE.SceneTree_set_screen_stretch(swigCPtr, mode, aspect, ref minsize);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void queue_delete(Object obj) {
    GodotEnginePINVOKE.SceneTree_queue_delete(swigCPtr, Object.getCPtr(obj));
  }

  public void call_group(int flags, string group, string method, Variant arg0_, Variant arg1_, Variant arg2_, Variant arg3_, Variant arg4_) {
    GodotEnginePINVOKE.SceneTree_call_group__SWIG_0(swigCPtr, flags, group, method, Variant.getCPtr(arg0_), Variant.getCPtr(arg1_), Variant.getCPtr(arg2_), Variant.getCPtr(arg3_), Variant.getCPtr(arg4_));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void call_group(int flags, string group, string method, Variant arg0_, Variant arg1_, Variant arg2_, Variant arg3_) {
    GodotEnginePINVOKE.SceneTree_call_group__SWIG_1(swigCPtr, flags, group, method, Variant.getCPtr(arg0_), Variant.getCPtr(arg1_), Variant.getCPtr(arg2_), Variant.getCPtr(arg3_));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void call_group(int flags, string group, string method, Variant arg0_, Variant arg1_, Variant arg2_) {
    GodotEnginePINVOKE.SceneTree_call_group__SWIG_2(swigCPtr, flags, group, method, Variant.getCPtr(arg0_), Variant.getCPtr(arg1_), Variant.getCPtr(arg2_));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void call_group(int flags, string group, string method, Variant arg0_, Variant arg1_) {
    GodotEnginePINVOKE.SceneTree_call_group__SWIG_3(swigCPtr, flags, group, method, Variant.getCPtr(arg0_), Variant.getCPtr(arg1_));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void call_group(int flags, string group, string method, Variant arg0_) {
    GodotEnginePINVOKE.SceneTree_call_group__SWIG_4(swigCPtr, flags, group, method, Variant.getCPtr(arg0_));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void call_group(int flags, string group, string method) {
    GodotEnginePINVOKE.SceneTree_call_group__SWIG_5(swigCPtr, flags, group, method);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_current_scene(Node child_node) {
    GodotEnginePINVOKE.SceneTree_set_current_scene(swigCPtr, Node.getCPtr(child_node));
  }

  public Node get_current_scene() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.SceneTree_get_current_scene(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Node ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Node;
    return ret;
  }

  public int change_scene(string path) {
    int ret = GodotEnginePINVOKE.SceneTree_change_scene(swigCPtr, path);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int change_scene_to(SWIGTYPE_p_RefT_PackedScene_t packed_scene) {
    int ret = GodotEnginePINVOKE.SceneTree_change_scene_to(swigCPtr, SWIGTYPE_p_RefT_PackedScene_t.getCPtr(packed_scene));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int reload_current_scene() {
    int ret = GodotEnginePINVOKE.SceneTree_reload_current_scene(swigCPtr);
    return ret;
  }

  public SceneTree() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_SceneTree());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}