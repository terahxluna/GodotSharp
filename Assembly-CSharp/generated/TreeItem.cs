/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class TreeItem : Object {
  public static readonly int CELL_MODE_STRING = 0;
  public static readonly int CELL_MODE_CHECK = 1;
  public static readonly int CELL_MODE_RANGE = 2;
  public static readonly int CELL_MODE_RANGE_EXPRESSION = 3;
  public static readonly int CELL_MODE_ICON = 4;
  public static readonly int CELL_MODE_CUSTOM = 5;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal TreeItem(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.TreeItem_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected TreeItem(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.TreeItem_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TreeItem obj) {
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

  internal TreeItem() {}


  public void set_cell_mode(int column, int mode) {
    GodotEnginePINVOKE.TreeItem_set_cell_mode(swigCPtr, column, mode);
  }

  public int get_cell_mode(int column) {
    int ret = GodotEnginePINVOKE.TreeItem_get_cell_mode(swigCPtr, column);
    return ret;
  }

  public void set_checked(int column, bool arg1) {
    GodotEnginePINVOKE.TreeItem_set_checked(swigCPtr, column, arg1);
  }

  public bool is_checked(int column) {
    bool ret = GodotEnginePINVOKE.TreeItem_is_checked(swigCPtr, column);
    return ret;
  }

  public void set_text(int column, string text) {
    GodotEnginePINVOKE.TreeItem_set_text(swigCPtr, column, text);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_text(int column) {
    string ret = GodotEnginePINVOKE.TreeItem_get_text(swigCPtr, column);
    return ret;
  }

  public void set_icon(int column, SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.TreeItem_set_icon(swigCPtr, column, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_Texture_t get_icon(int column) {
    SWIGTYPE_p_RefT_Texture_t ret = new SWIGTYPE_p_RefT_Texture_t(GodotEnginePINVOKE.TreeItem_get_icon(swigCPtr, column), true);
    return ret;
  }

  public void set_icon_region(int column, SWIGTYPE_p_Rect2 region) {
    GodotEnginePINVOKE.TreeItem_set_icon_region(swigCPtr, column, SWIGTYPE_p_Rect2.getCPtr(region));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Rect2 get_icon_region(int column) {
    SWIGTYPE_p_Rect2 ret = new SWIGTYPE_p_Rect2(GodotEnginePINVOKE.TreeItem_get_icon_region(swigCPtr, column), true);
    return ret;
  }

  public void set_icon_max_width(int column, int width) {
    GodotEnginePINVOKE.TreeItem_set_icon_max_width(swigCPtr, column, width);
  }

  public int get_icon_max_width(int column) {
    int ret = GodotEnginePINVOKE.TreeItem_get_icon_max_width(swigCPtr, column);
    return ret;
  }

  public void set_range(int column, float value) {
    GodotEnginePINVOKE.TreeItem_set_range(swigCPtr, column, value);
  }

  public float get_range(int column) {
    float ret = GodotEnginePINVOKE.TreeItem_get_range(swigCPtr, column);
    return ret;
  }

  public void set_range_config(int column, float min, float max, float step, bool expr) {
    GodotEnginePINVOKE.TreeItem_set_range_config__SWIG_0(swigCPtr, column, min, max, step, expr);
  }

  public void set_range_config(int column, float min, float max, float step) {
    GodotEnginePINVOKE.TreeItem_set_range_config__SWIG_1(swigCPtr, column, min, max, step);
  }

  public SWIGTYPE_p_Dictionary get_range_config(int column) {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.TreeItem_get_range_config(swigCPtr, column), true);
    return ret;
  }

  public void set_metadata(int column, Variant meta) {
    GodotEnginePINVOKE.TreeItem_set_metadata(swigCPtr, column, Variant.getCPtr(meta));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void get_metadata(int column) {
    GodotEnginePINVOKE.TreeItem_get_metadata(swigCPtr, column);
  }

  public void set_custom_draw(int column, Object arg1, string callback) {
    GodotEnginePINVOKE.TreeItem_set_custom_draw(swigCPtr, column, Object.getCPtr(arg1), callback);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_collapsed(bool enable) {
    GodotEnginePINVOKE.TreeItem_set_collapsed(swigCPtr, enable);
  }

  public bool is_collapsed() {
    bool ret = GodotEnginePINVOKE.TreeItem_is_collapsed(swigCPtr);
    return ret;
  }

  public TreeItem get_next() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TreeItem_get_next(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem get_prev() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TreeItem_get_prev(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem get_parent() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TreeItem_get_parent(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem get_children() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TreeItem_get_children(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem get_next_visible() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TreeItem_get_next_visible(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem get_prev_visible() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TreeItem_get_prev_visible(swigCPtr);
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public TreeItem remove_child(Object child) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TreeItem_remove_child(swigCPtr, Object.getCPtr(child));
    TreeItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new TreeItem(cPtr, false);
    return ret;
  }

  public void set_selectable(int column, bool selectable) {
    GodotEnginePINVOKE.TreeItem_set_selectable(swigCPtr, column, selectable);
  }

  public bool is_selectable(int column) {
    bool ret = GodotEnginePINVOKE.TreeItem_is_selectable(swigCPtr, column);
    return ret;
  }

  public bool is_selected(int column) {
    bool ret = GodotEnginePINVOKE.TreeItem_is_selected(swigCPtr, column);
    return ret;
  }

  public void select(int column) {
    GodotEnginePINVOKE.TreeItem_select(swigCPtr, column);
  }

  public void deselect(int column) {
    GodotEnginePINVOKE.TreeItem_deselect(swigCPtr, column);
  }

  public void set_editable(int column, bool enabled) {
    GodotEnginePINVOKE.TreeItem_set_editable(swigCPtr, column, enabled);
  }

  public bool is_editable(int column) {
    bool ret = GodotEnginePINVOKE.TreeItem_is_editable(swigCPtr, column);
    return ret;
  }

  public void set_custom_color(int column, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.TreeItem_set_custom_color(swigCPtr, column, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear_custom_color(int column) {
    GodotEnginePINVOKE.TreeItem_clear_custom_color(swigCPtr, column);
  }

  public void set_custom_bg_color(int column, SWIGTYPE_p_Color color, bool just_outline) {
    GodotEnginePINVOKE.TreeItem_set_custom_bg_color__SWIG_0(swigCPtr, column, SWIGTYPE_p_Color.getCPtr(color), just_outline);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_custom_bg_color(int column, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.TreeItem_set_custom_bg_color__SWIG_1(swigCPtr, column, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear_custom_bg_color(int column) {
    GodotEnginePINVOKE.TreeItem_clear_custom_bg_color(swigCPtr, column);
  }

  public SWIGTYPE_p_Color get_custom_bg_color(int column) {
    SWIGTYPE_p_Color ret = new SWIGTYPE_p_Color(GodotEnginePINVOKE.TreeItem_get_custom_bg_color(swigCPtr, column), true);
    return ret;
  }

  public void add_button(int column, SWIGTYPE_p_RefT_Texture_t button, int button_idx, bool disabled) {
    GodotEnginePINVOKE.TreeItem_add_button__SWIG_0(swigCPtr, column, SWIGTYPE_p_RefT_Texture_t.getCPtr(button), button_idx, disabled);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_button(int column, SWIGTYPE_p_RefT_Texture_t button, int button_idx) {
    GodotEnginePINVOKE.TreeItem_add_button__SWIG_1(swigCPtr, column, SWIGTYPE_p_RefT_Texture_t.getCPtr(button), button_idx);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_button(int column, SWIGTYPE_p_RefT_Texture_t button) {
    GodotEnginePINVOKE.TreeItem_add_button__SWIG_2(swigCPtr, column, SWIGTYPE_p_RefT_Texture_t.getCPtr(button));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_button_count(int column) {
    int ret = GodotEnginePINVOKE.TreeItem_get_button_count(swigCPtr, column);
    return ret;
  }

  public SWIGTYPE_p_RefT_Texture_t get_button(int column, int button_idx) {
    SWIGTYPE_p_RefT_Texture_t ret = new SWIGTYPE_p_RefT_Texture_t(GodotEnginePINVOKE.TreeItem_get_button(swigCPtr, column, button_idx), true);
    return ret;
  }

  public void erase_button(int column, int button_idx) {
    GodotEnginePINVOKE.TreeItem_erase_button(swigCPtr, column, button_idx);
  }

  public bool is_button_disabled(int column, int button_idx) {
    bool ret = GodotEnginePINVOKE.TreeItem_is_button_disabled(swigCPtr, column, button_idx);
    return ret;
  }

  public void set_tooltip(int column, string tooltip) {
    GodotEnginePINVOKE.TreeItem_set_tooltip(swigCPtr, column, tooltip);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_tooltip(int column) {
    string ret = GodotEnginePINVOKE.TreeItem_get_tooltip(swigCPtr, column);
    return ret;
  }

  public void move_to_top() {
    GodotEnginePINVOKE.TreeItem_move_to_top(swigCPtr);
  }

  public void move_to_bottom() {
    GodotEnginePINVOKE.TreeItem_move_to_bottom(swigCPtr);
  }

}

}
