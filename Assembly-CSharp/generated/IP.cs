/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class IP : Object {
  private static IP instance;
  public static readonly int RESOLVER_STATUS_NONE = 0;
  public static readonly int RESOLVER_STATUS_WAITING = 1;
  public static readonly int RESOLVER_STATUS_DONE = 2;
  public static readonly int RESOLVER_STATUS_ERROR = 3;
  public static readonly int RESOLVER_MAX_QUERIES = 32;
  public static readonly int RESOLVER_INVALID_ID = -1;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal IP(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.IP_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected IP(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.IP_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IP obj) {
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

  public static IP Instance {
    get {
      if (instance == null) {
        instance = SingletonGetInstance();
      }
      return instance;
    }
  }

  internal IP() {}


  public string resolve_hostname(string host) {
    string ret = GodotEnginePINVOKE.IP_resolve_hostname(swigCPtr, host);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int resolve_hostname_queue_item(string host) {
    int ret = GodotEnginePINVOKE.IP_resolve_hostname_queue_item(swigCPtr, host);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int get_resolve_item_status(int id) {
    int ret = GodotEnginePINVOKE.IP_get_resolve_item_status(swigCPtr, id);
    return ret;
  }

  public string get_resolve_item_address(int id) {
    string ret = GodotEnginePINVOKE.IP_get_resolve_item_address(swigCPtr, id);
    return ret;
  }

  public void erase_resolve_item(int id) {
    GodotEnginePINVOKE.IP_erase_resolve_item(swigCPtr, id);
  }

  public SWIGTYPE_p_Array get_local_addresses() {
    SWIGTYPE_p_Array ret = new SWIGTYPE_p_Array(GodotEnginePINVOKE.IP_get_local_addresses(swigCPtr), true);
    return ret;
  }

  private static IP SingletonGetInstance() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.IP_SingletonGetInstance();
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    IP ret = InternalHelpers.UnmanagedGetManaged(cPtr) as IP;
    return ret;
  }

}

}
