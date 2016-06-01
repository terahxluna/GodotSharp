/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Input : Object {
  private static Input instance;
  public static readonly int MOUSE_MODE_VISIBLE = 0;
  public static readonly int MOUSE_MODE_HIDDEN = 1;
  public static readonly int MOUSE_MODE_CAPTURED = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Input(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Input_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Input(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Input_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Input obj) {
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

  public static Input Instance {
    get {
      if (instance == null) {
        instance = SingletonGetInstance();
      }
      return instance;
    }
  }

  internal Input() {}


  public bool is_key_pressed(int scancode) {
    bool ret = GodotEnginePINVOKE.Input_is_key_pressed(swigCPtr, scancode);
    return ret;
  }

  public bool is_mouse_button_pressed(int button) {
    bool ret = GodotEnginePINVOKE.Input_is_mouse_button_pressed(swigCPtr, button);
    return ret;
  }

  public bool is_joy_button_pressed(int device, int button) {
    bool ret = GodotEnginePINVOKE.Input_is_joy_button_pressed(swigCPtr, device, button);
    return ret;
  }

  public bool is_action_pressed(string action) {
    bool ret = GodotEnginePINVOKE.Input_is_action_pressed(swigCPtr, action);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void add_joy_mapping(string mapping, bool update_existing) {
    GodotEnginePINVOKE.Input_add_joy_mapping__SWIG_0(swigCPtr, mapping, update_existing);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_joy_mapping(string mapping) {
    GodotEnginePINVOKE.Input_add_joy_mapping__SWIG_1(swigCPtr, mapping);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void remove_joy_mapping(string guid) {
    GodotEnginePINVOKE.Input_remove_joy_mapping(swigCPtr, guid);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool is_joy_known(int device) {
    bool ret = GodotEnginePINVOKE.Input_is_joy_known(swigCPtr, device);
    return ret;
  }

  public float get_joy_axis(int device, int axis) {
    float ret = GodotEnginePINVOKE.Input_get_joy_axis(swigCPtr, device, axis);
    return ret;
  }

  public string get_joy_name(int device) {
    string ret = GodotEnginePINVOKE.Input_get_joy_name(swigCPtr, device);
    return ret;
  }

  public string get_joy_guid(int device) {
    string ret = GodotEnginePINVOKE.Input_get_joy_guid(swigCPtr, device);
    return ret;
  }

  public SWIGTYPE_p_Vector3 get_accelerometer() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.Input_get_accelerometer(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Vector3 get_magnetometer() {
    SWIGTYPE_p_Vector3 ret = new SWIGTYPE_p_Vector3(GodotEnginePINVOKE.Input_get_magnetometer(swigCPtr), true);
    return ret;
  }

  public Vector2 get_mouse_speed() {
    Vector2 ret = new Vector2(GodotEnginePINVOKE.Input_get_mouse_speed(swigCPtr), true);
    return ret;
  }

  public int get_mouse_button_mask() {
    int ret = GodotEnginePINVOKE.Input_get_mouse_button_mask(swigCPtr);
    return ret;
  }

  public void set_mouse_mode(int mode) {
    GodotEnginePINVOKE.Input_set_mouse_mode(swigCPtr, mode);
  }

  public int get_mouse_mode() {
    int ret = GodotEnginePINVOKE.Input_get_mouse_mode(swigCPtr);
    return ret;
  }

  public void warp_mouse_pos(Vector2 to) {
    GodotEnginePINVOKE.Input_warp_mouse_pos(swigCPtr, Vector2.getCPtr(to));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void action_press(string action) {
    GodotEnginePINVOKE.Input_action_press(swigCPtr, action);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void action_release(string action) {
    GodotEnginePINVOKE.Input_action_release(swigCPtr, action);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_custom_mouse_cursor(SWIGTYPE_p_RefT_Texture_t image, Vector2 hotspot) {
    GodotEnginePINVOKE.Input_set_custom_mouse_cursor__SWIG_0(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(image), Vector2.getCPtr(hotspot));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_custom_mouse_cursor(SWIGTYPE_p_RefT_Texture_t image) {
    GodotEnginePINVOKE.Input_set_custom_mouse_cursor__SWIG_1(swigCPtr, SWIGTYPE_p_RefT_Texture_t.getCPtr(image));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private static Input SingletonGetInstance() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Input_SingletonGetInstance();
    Input ret = (cPtr == global::System.IntPtr.Zero) ? null : new Input(cPtr, false);
    return ret;
  }

}

}
