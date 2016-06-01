/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class SceneState : Reference {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal SceneState(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.SceneState_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected SceneState(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.SceneState_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SceneState obj) {
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

  internal SceneState() {}


  public int get_node_count() {
    int ret = GodotEnginePINVOKE.SceneState_get_node_count(swigCPtr);
    return ret;
  }

  public string get_node_type(int idx) {
    string ret = GodotEnginePINVOKE.SceneState_get_node_type(swigCPtr, idx);
    return ret;
  }

  public string get_node_name(int idx) {
    string ret = GodotEnginePINVOKE.SceneState_get_node_name(swigCPtr, idx);
    return ret;
  }

  public NodePath get_node_path(int idx, bool for_parent) {
    NodePath ret = new NodePath(GodotEnginePINVOKE.SceneState_get_node_path__SWIG_0(swigCPtr, idx, for_parent), true);
    return ret;
  }

  public NodePath get_node_path(int idx) {
    NodePath ret = new NodePath(GodotEnginePINVOKE.SceneState_get_node_path__SWIG_1(swigCPtr, idx), true);
    return ret;
  }

  public NodePath get_node_owner_path(int idx) {
    NodePath ret = new NodePath(GodotEnginePINVOKE.SceneState_get_node_owner_path(swigCPtr, idx), true);
    return ret;
  }

  public bool is_node_instance_placeholder(int idx) {
    bool ret = GodotEnginePINVOKE.SceneState_is_node_instance_placeholder(swigCPtr, idx);
    return ret;
  }

  public string get_node_instance_placeholder(int idx) {
    string ret = GodotEnginePINVOKE.SceneState_get_node_instance_placeholder(swigCPtr, idx);
    return ret;
  }

  public SWIGTYPE_p_RefT_PackedScene_t get_node_instance(int idx) {
    SWIGTYPE_p_RefT_PackedScene_t ret = new SWIGTYPE_p_RefT_PackedScene_t(GodotEnginePINVOKE.SceneState_get_node_instance(swigCPtr, idx), true);
    return ret;
  }

  public SWIGTYPE_p_StringArray get_node_groups(int idx) {
    SWIGTYPE_p_StringArray ret = new SWIGTYPE_p_StringArray(GodotEnginePINVOKE.SceneState_get_node_groups(swigCPtr, idx), true);
    return ret;
  }

  public int get_node_property_count(int idx) {
    int ret = GodotEnginePINVOKE.SceneState_get_node_property_count(swigCPtr, idx);
    return ret;
  }

  public string get_node_property_name(int idx, int prop_idx) {
    string ret = GodotEnginePINVOKE.SceneState_get_node_property_name(swigCPtr, idx, prop_idx);
    return ret;
  }

  public void get_node_property_value(int idx, int prop_idx) {
    GodotEnginePINVOKE.SceneState_get_node_property_value(swigCPtr, idx, prop_idx);
  }

  public int get_connection_count() {
    int ret = GodotEnginePINVOKE.SceneState_get_connection_count(swigCPtr);
    return ret;
  }

  public NodePath get_connection_source(int idx) {
    NodePath ret = new NodePath(GodotEnginePINVOKE.SceneState_get_connection_source(swigCPtr, idx), true);
    return ret;
  }

  public string get_connection_signal(int idx) {
    string ret = GodotEnginePINVOKE.SceneState_get_connection_signal(swigCPtr, idx);
    return ret;
  }

  public NodePath get_connection_target(int idx) {
    NodePath ret = new NodePath(GodotEnginePINVOKE.SceneState_get_connection_target(swigCPtr, idx), true);
    return ret;
  }

  public string get_connection_method(int idx) {
    string ret = GodotEnginePINVOKE.SceneState_get_connection_method(swigCPtr, idx);
    return ret;
  }

  public int get_connection_flags(int idx) {
    int ret = GodotEnginePINVOKE.SceneState_get_connection_flags(swigCPtr, idx);
    return ret;
  }

  public SWIGTYPE_p_Array get_connection_binds(int idx) {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.SceneState_get_connection_binds(swigCPtr, idx), true);
    return ret;
  }

}

}
