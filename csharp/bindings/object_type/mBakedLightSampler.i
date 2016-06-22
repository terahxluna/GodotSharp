/* mBakedLightSampler.i */
%module mBakedLightSampler

%typemap(out) BakedLightSampler "$result = memnew($1_ltype((const $1_ltype &)$1));"
%typemap(csout, excode=SWIGEXCODE) BakedLightSampler* {
    global::System.IntPtr cPtr = $imcall;
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    $csclassname ret = InternalHelpers.UnmanagedGetManaged(cPtr) as $csclassname;$excode
    return ret;
  }


%typemap(csbody_derived) BakedLightSampler %{
  public static readonly int PARAM_RADIUS = 0;
  public static readonly int PARAM_STRENGTH = 1;
  public static readonly int PARAM_ATTENUATION = 2;
  public static readonly int PARAM_DETAIL_RATIO = 3;
  public static readonly int PARAM_MAX = 4;

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

%typemap(cscode) BakedLightSampler %{

%}

%typemap(csconstruct, excode=SWIGEXCODE) BakedLightSampler %{: this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }$excode
  }
%}

%nodefaultdtor BakedLightSampler;

class BakedLightSampler : public VisualInstance {
public:
  %extend {
    void set_param(int param, float value) {
  Object* self_obj = static_cast<Object*>($self);
  self_obj->call("set_param", param, value);
    }
  }
  %extend {
    float get_param(int param) {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("get_param", param);
    }
  }
  %extend {
    void set_resolution(int resolution) {
  Object* self_obj = static_cast<Object*>($self);
  self_obj->call("set_resolution", resolution);
    }
  }
  %extend {
    int get_resolution() {
  Object* self_obj = static_cast<Object*>($self);
  return self_obj->call("get_resolution");
    }
  }
  BakedLightSampler();

};
