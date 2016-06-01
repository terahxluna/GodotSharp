/* mRegEx.i */
%module mRegEx


%typemap(csbody_derived) RegEx %{

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal $csclassname(global::System.IntPtr cPtr, bool cMemoryOwn) : base($imclassname.$csclazznameSWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected $csclassname(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init($imclassname.$csclazznameSWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr($csclassname obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }
%}

%typemap(cscode) RegEx %{

%}

%typemap(csconstruct, excode=SWIGEXCODE) RegEx %{: this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
    }$excode
  }
%}

%nodefaultdtor RegEx;

class RegEx : public Reference {
public:
  %extend {
    int compile(const String& pattern, int capture = 9) {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("compile", pattern, capture);
    }
  }
  %extend {
    int find(const String& text, int start = 0, int end = -1) {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("find", text, start, end);
    }
  }
  %extend {
    void clear() {
  Object* self_obj = static_cast<Object*>($self);
  self_obj->call("clear");
    }
  }
  %extend {
    bool is_valid() {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("is_valid");
    }
  }
  %extend {
    int get_capture_count() {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("get_capture_count");
    }
  }
  %extend {
    String get_capture(int capture) {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("get_capture", capture);
    }
  }
  %extend {
    int get_capture_start(int capture) {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("get_capture_start", capture);
    }
  }
  %extend {
    StringArray get_captures() {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("get_captures");
    }
  }
  RegEx();

};
