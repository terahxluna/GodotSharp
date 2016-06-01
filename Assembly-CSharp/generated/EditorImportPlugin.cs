/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class EditorImportPlugin : Reference {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal EditorImportPlugin(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.EditorImportPlugin_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected EditorImportPlugin(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.EditorImportPlugin_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EditorImportPlugin obj) {
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



  public bool can_reimport_multiple_files() {
    bool ret = GodotEnginePINVOKE.EditorImportPlugin_can_reimport_multiple_files(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_RawArray custom_export(string path, SWIGTYPE_p_EditorExportPlatform platform) {
    SWIGTYPE_p_RawArray ret = new SWIGTYPE_p_RawArray(GodotEnginePINVOKE.EditorImportPlugin_custom_export(swigCPtr, path, SWIGTYPE_p_EditorExportPlatform.getCPtr(platform)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string get_name() {
    string ret = GodotEnginePINVOKE.EditorImportPlugin_get_name(swigCPtr);
    return ret;
  }

  public string get_visible_name() {
    string ret = GodotEnginePINVOKE.EditorImportPlugin_get_visible_name(swigCPtr);
    return ret;
  }

  public int import(string path, SWIGTYPE_p_RefT_ResourceImportMetadata_t from) {
    int ret = GodotEnginePINVOKE.EditorImportPlugin_import(swigCPtr, path, SWIGTYPE_p_RefT_ResourceImportMetadata_t.getCPtr(from));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void import_dialog(string from) {
    GodotEnginePINVOKE.EditorImportPlugin_import_dialog(swigCPtr, from);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void import_from_drop(SWIGTYPE_p_StringArray files, string dest_path) {
    GodotEnginePINVOKE.EditorImportPlugin_import_from_drop(swigCPtr, SWIGTYPE_p_StringArray.getCPtr(files), dest_path);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reimport_multiple_files(SWIGTYPE_p_StringArray files) {
    GodotEnginePINVOKE.EditorImportPlugin_reimport_multiple_files(swigCPtr, SWIGTYPE_p_StringArray.getCPtr(files));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string validate_source_path(string path) {
    string ret = GodotEnginePINVOKE.EditorImportPlugin_validate_source_path(swigCPtr, path);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string expand_source_path(string path) {
    string ret = GodotEnginePINVOKE.EditorImportPlugin_expand_source_path(swigCPtr, path);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public EditorImportPlugin() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_EditorImportPlugin());
    }
  }

}

}
