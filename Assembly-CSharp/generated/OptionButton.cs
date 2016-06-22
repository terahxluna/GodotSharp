/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class OptionButton : Button {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal OptionButton(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.OptionButton_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected OptionButton(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.OptionButton_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OptionButton obj) {
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



  public void add_item(string label, int id) {
    GodotEnginePINVOKE.OptionButton_add_item__SWIG_0(swigCPtr, label, id);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_item(string label) {
    GodotEnginePINVOKE.OptionButton_add_item__SWIG_1(swigCPtr, label);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_icon_item(Texture texture, string label, int id) {
    GodotEnginePINVOKE.OptionButton_add_icon_item(swigCPtr, Texture.getCPtr(texture), label, id);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_item_text(int idx, string text) {
    GodotEnginePINVOKE.OptionButton_set_item_text(swigCPtr, idx, text);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_item_icon(int idx, Texture texture) {
    GodotEnginePINVOKE.OptionButton_set_item_icon(swigCPtr, idx, Texture.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_item_disabled(int idx, bool disabled) {
    GodotEnginePINVOKE.OptionButton_set_item_disabled(swigCPtr, idx, disabled);
  }

  public void set_item_ID(int idx, int id) {
    GodotEnginePINVOKE.OptionButton_set_item_ID(swigCPtr, idx, id);
  }

  public void set_item_metadata(int idx, Variant metadata) {
    GodotEnginePINVOKE.OptionButton_set_item_metadata(swigCPtr, idx, Variant.getCPtr(metadata));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_item_text(int idx) {
    string ret = GodotEnginePINVOKE.OptionButton_get_item_text(swigCPtr, idx);
    return ret;
  }

  public Texture get_item_icon(int idx) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.OptionButton_get_item_icon(swigCPtr, idx);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Texture ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Texture;
    return ret;
}

  public int get_item_ID(int idx) {
    int ret = GodotEnginePINVOKE.OptionButton_get_item_ID(swigCPtr, idx);
    return ret;
  }

  public void get_item_metadata(int idx) {
    GodotEnginePINVOKE.OptionButton_get_item_metadata(swigCPtr, idx);
  }

  public bool is_item_disabled(int idx) {
    bool ret = GodotEnginePINVOKE.OptionButton_is_item_disabled(swigCPtr, idx);
    return ret;
  }

  public int get_item_count() {
    int ret = GodotEnginePINVOKE.OptionButton_get_item_count(swigCPtr);
    return ret;
  }

  public void add_separator() {
    GodotEnginePINVOKE.OptionButton_add_separator(swigCPtr);
  }

  public void clear() {
    GodotEnginePINVOKE.OptionButton_clear(swigCPtr);
  }

  public void select(int idx) {
    GodotEnginePINVOKE.OptionButton_select(swigCPtr, idx);
  }

  public int get_selected() {
    int ret = GodotEnginePINVOKE.OptionButton_get_selected(swigCPtr);
    return ret;
  }

  public int get_selected_ID() {
    int ret = GodotEnginePINVOKE.OptionButton_get_selected_ID(swigCPtr);
    return ret;
  }

  public void get_selected_metadata() {
    GodotEnginePINVOKE.OptionButton_get_selected_metadata(swigCPtr);
  }

  public void remove_item(int idx) {
    GodotEnginePINVOKE.OptionButton_remove_item(swigCPtr, idx);
  }

  public OptionButton() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_OptionButton());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
