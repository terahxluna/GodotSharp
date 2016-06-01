/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class NavigationMeshInstance : Spatial {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal NavigationMeshInstance(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.NavigationMeshInstance_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected NavigationMeshInstance(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.NavigationMeshInstance_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NavigationMeshInstance obj) {
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



  public void set_navigation_mesh(Object navmesh) {
    GodotEnginePINVOKE.NavigationMeshInstance_set_navigation_mesh(swigCPtr, Object.getCPtr(navmesh));
  }

  public Object get_navigation_mesh() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.NavigationMeshInstance_get_navigation_mesh(swigCPtr);
    Object ret = InternalHelpers.GetManagedObjectFor(cPtr);
    if (ret == null) {
      ret = new Object(cPtr, false);
    }
    return ret;
  }

  public void set_enabled(bool enabled) {
    GodotEnginePINVOKE.NavigationMeshInstance_set_enabled(swigCPtr, enabled);
  }

  public bool is_enabled() {
    bool ret = GodotEnginePINVOKE.NavigationMeshInstance_is_enabled(swigCPtr);
    return ret;
  }

  public NavigationMeshInstance() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_NavigationMeshInstance());
    }
  }

}

}
