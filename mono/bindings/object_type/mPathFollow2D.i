/* mPathFollow2D.i */
%module mPathFollow2D


%typemap(csbody_derived) PathFollow2D %{

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

%typemap(cscode) PathFollow2D %{

%}

%typemap(csconstruct, excode=SWIGEXCODE) PathFollow2D %{: this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }$excode
  }
%}

%nodefaultdtor PathFollow2D;

class PathFollow2D : public Node2D {
public:
  PathFollow2D();

%extend {

void set_offset(float offset) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "set_offset");
  const void* __args[1] = { &offset };
  __method_bind->ptrcall($self, __args, NULL);
}

float get_offset() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "get_offset");
  float ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_h_offset(float h_offset) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "set_h_offset");
  const void* __args[1] = { &h_offset };
  __method_bind->ptrcall($self, __args, NULL);
}

float get_h_offset() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "get_h_offset");
  float ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_v_offset(float v_offset) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "set_v_offset");
  const void* __args[1] = { &v_offset };
  __method_bind->ptrcall($self, __args, NULL);
}

float get_v_offset() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "get_v_offset");
  float ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_unit_offset(float unit_offset) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "set_unit_offset");
  const void* __args[1] = { &unit_offset };
  __method_bind->ptrcall($self, __args, NULL);
}

float get_unit_offset() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "get_unit_offset");
  float ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_rotate(bool enable) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "set_rotate");
  const void* __args[1] = { &enable };
  __method_bind->ptrcall($self, __args, NULL);
}

bool is_rotating() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "is_rotating");
  bool ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_cubic_interpolation(bool enable) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "set_cubic_interpolation");
  const void* __args[1] = { &enable };
  __method_bind->ptrcall($self, __args, NULL);
}

bool get_cubic_interpolation() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "get_cubic_interpolation");
  bool ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_loop(bool loop) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "set_loop");
  const void* __args[1] = { &loop };
  __method_bind->ptrcall($self, __args, NULL);
}

bool has_loop() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("PathFollow2D", "has_loop");
  bool ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

}


};