/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Physics2DShapeQueryResult : Reference {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Physics2DShapeQueryResult(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Physics2DShapeQueryResult_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Physics2DShapeQueryResult(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Physics2DShapeQueryResult_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Physics2DShapeQueryResult obj) {
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

  internal Physics2DShapeQueryResult() {}


  public int get_result_count() {
    int ret = GodotEnginePINVOKE.Physics2DShapeQueryResult_get_result_count(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_RID get_result_rid(int idx) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.Physics2DShapeQueryResult_get_result_rid(swigCPtr, idx), true);
    return ret;
  }

  public int get_result_object_id(int idx) {
    int ret = GodotEnginePINVOKE.Physics2DShapeQueryResult_get_result_object_id(swigCPtr, idx);
    return ret;
  }

  public Object get_result_object(int idx) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.Physics2DShapeQueryResult_get_result_object(swigCPtr, idx);
    if (cPtr == global::System.IntPtr.Zero)
    	return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public int get_result_object_shape(int idx) {
    int ret = GodotEnginePINVOKE.Physics2DShapeQueryResult_get_result_object_shape(swigCPtr, idx);
    return ret;
  }

}

}