/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class TextEdit : Control {
  public static readonly int SEARCH_MATCH_CASE = 1;
  public static readonly int SEARCH_WHOLE_WORDS = 2;
  public static readonly int SEARCH_BACKWARDS = 4;
  public static readonly int MENU_CUT = 0;
  public static readonly int MENU_COPY = 1;
  public static readonly int MENU_PASTE = 2;
  public static readonly int MENU_CLEAR = 3;
  public static readonly int MENU_SELECT_ALL = 4;
  public static readonly int MENU_UNDO = 5;
  public static readonly int MENU_MAX = 6;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal TextEdit(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.TextEdit_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected TextEdit(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.TextEdit_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextEdit obj) {
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



  public void set_text(string text) {
    GodotEnginePINVOKE.TextEdit_set_text(swigCPtr, text);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void insert_text_at_cursor(string text) {
    GodotEnginePINVOKE.TextEdit_insert_text_at_cursor(swigCPtr, text);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_line_count() {
    int ret = GodotEnginePINVOKE.TextEdit_get_line_count(swigCPtr);
    return ret;
  }

  public string get_text() {
    string ret = GodotEnginePINVOKE.TextEdit_get_text(swigCPtr);
    return ret;
  }

  public string get_line(int line) {
    string ret = GodotEnginePINVOKE.TextEdit_get_line(swigCPtr, line);
    return ret;
  }

  public void cursor_set_column(int column, bool adjust_viewport) {
    GodotEnginePINVOKE.TextEdit_cursor_set_column__SWIG_0(swigCPtr, column, adjust_viewport);
  }

  public void cursor_set_column(int column) {
    GodotEnginePINVOKE.TextEdit_cursor_set_column__SWIG_1(swigCPtr, column);
  }

  public void cursor_set_line(int line, bool adjust_viewport) {
    GodotEnginePINVOKE.TextEdit_cursor_set_line__SWIG_0(swigCPtr, line, adjust_viewport);
  }

  public void cursor_set_line(int line) {
    GodotEnginePINVOKE.TextEdit_cursor_set_line__SWIG_1(swigCPtr, line);
  }

  public int cursor_get_column() {
    int ret = GodotEnginePINVOKE.TextEdit_cursor_get_column(swigCPtr);
    return ret;
  }

  public int cursor_get_line() {
    int ret = GodotEnginePINVOKE.TextEdit_cursor_get_line(swigCPtr);
    return ret;
  }

  public void cursor_set_blink_enabled(bool enable) {
    GodotEnginePINVOKE.TextEdit_cursor_set_blink_enabled(swigCPtr, enable);
  }

  public bool cursor_get_blink_enabled() {
    bool ret = GodotEnginePINVOKE.TextEdit_cursor_get_blink_enabled(swigCPtr);
    return ret;
  }

  public void cursor_set_blink_speed(float blink_speed) {
    GodotEnginePINVOKE.TextEdit_cursor_set_blink_speed(swigCPtr, blink_speed);
  }

  public float cursor_get_blink_speed() {
    float ret = GodotEnginePINVOKE.TextEdit_cursor_get_blink_speed(swigCPtr);
    return ret;
  }

  public void set_readonly(bool enable) {
    GodotEnginePINVOKE.TextEdit_set_readonly(swigCPtr, enable);
  }

  public void set_wrap(bool enable) {
    GodotEnginePINVOKE.TextEdit_set_wrap(swigCPtr, enable);
  }

  public void set_max_chars(int amount) {
    GodotEnginePINVOKE.TextEdit_set_max_chars(swigCPtr, amount);
  }

  public void cut() {
    GodotEnginePINVOKE.TextEdit_cut(swigCPtr);
  }

  public void copy() {
    GodotEnginePINVOKE.TextEdit_copy(swigCPtr);
  }

  public void paste() {
    GodotEnginePINVOKE.TextEdit_paste(swigCPtr);
  }

  public void select_all() {
    GodotEnginePINVOKE.TextEdit_select_all(swigCPtr);
  }

  public void select(int from_line, int from_column, int to_line, int to_column) {
    GodotEnginePINVOKE.TextEdit_select(swigCPtr, from_line, from_column, to_line, to_column);
  }

  public bool is_selection_active() {
    bool ret = GodotEnginePINVOKE.TextEdit_is_selection_active(swigCPtr);
    return ret;
  }

  public int get_selection_from_line() {
    int ret = GodotEnginePINVOKE.TextEdit_get_selection_from_line(swigCPtr);
    return ret;
  }

  public int get_selection_from_column() {
    int ret = GodotEnginePINVOKE.TextEdit_get_selection_from_column(swigCPtr);
    return ret;
  }

  public int get_selection_to_line() {
    int ret = GodotEnginePINVOKE.TextEdit_get_selection_to_line(swigCPtr);
    return ret;
  }

  public int get_selection_to_column() {
    int ret = GodotEnginePINVOKE.TextEdit_get_selection_to_column(swigCPtr);
    return ret;
  }

  public string get_selection_text() {
    string ret = GodotEnginePINVOKE.TextEdit_get_selection_text(swigCPtr);
    return ret;
  }

  public string get_word_under_cursor() {
    string ret = GodotEnginePINVOKE.TextEdit_get_word_under_cursor(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_IntArray search(string flags, int from_line, int from_column, int to_line) {
    SWIGTYPE_p_IntArray ret = new SWIGTYPE_p_IntArray(GodotEnginePINVOKE.TextEdit_search(swigCPtr, flags, from_line, from_column, to_line), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void undo() {
    GodotEnginePINVOKE.TextEdit_undo(swigCPtr);
  }

  public void redo() {
    GodotEnginePINVOKE.TextEdit_redo(swigCPtr);
  }

  public void clear_undo_history() {
    GodotEnginePINVOKE.TextEdit_clear_undo_history(swigCPtr);
  }

  public void set_syntax_coloring(bool enable) {
    GodotEnginePINVOKE.TextEdit_set_syntax_coloring(swigCPtr, enable);
  }

  public bool is_syntax_coloring_enabled() {
    bool ret = GodotEnginePINVOKE.TextEdit_is_syntax_coloring_enabled(swigCPtr);
    return ret;
  }

  public void add_keyword_color(string keyword, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.TextEdit_add_keyword_color(swigCPtr, keyword, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_color_region(string begin_key, string end_key, SWIGTYPE_p_Color color, bool line_only) {
    GodotEnginePINVOKE.TextEdit_add_color_region__SWIG_0(swigCPtr, begin_key, end_key, SWIGTYPE_p_Color.getCPtr(color), line_only);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_color_region(string begin_key, string end_key, SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.TextEdit_add_color_region__SWIG_1(swigCPtr, begin_key, end_key, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_symbol_color(SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.TextEdit_set_symbol_color(swigCPtr, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_custom_bg_color(SWIGTYPE_p_Color color) {
    GodotEnginePINVOKE.TextEdit_set_custom_bg_color(swigCPtr, SWIGTYPE_p_Color.getCPtr(color));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear_colors() {
    GodotEnginePINVOKE.TextEdit_clear_colors(swigCPtr);
  }

  public void menu_option(int arg0_) {
    GodotEnginePINVOKE.TextEdit_menu_option(swigCPtr, arg0_);
  }

  public PopupMenu get_menu() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.TextEdit_get_menu(swigCPtr);
    PopupMenu ret = (cPtr == global::System.IntPtr.Zero) ? null : new PopupMenu(cPtr, false);
    return ret;
  }

  public TextEdit() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_TextEdit());
    }
  }

}

}
