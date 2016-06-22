/* mAudioStream.i */
%module mAudioStream

%nodefaultctor AudioStream;
%typemap(ctype, out="AudioStream*") Ref<AudioStream> "AudioStream*"
%typemap(out, null="NULL") Ref<AudioStream> %{
  $result = $1.ptr();
  $result->reference();
%}
%typemap(csin) Ref<AudioStream> "AudioStream.getCPtr($csinput)"
%typemap(imtype, out="global::System.IntPtr") Ref<AudioStream> "global::System.Runtime.InteropServices.HandleRef"
%typemap(cstype) Ref<AudioStream> "AudioStream"
%typemap(csout, excode=SWIGEXCODE) Ref<AudioStream> {
    global::System.IntPtr cPtr = $imcall;
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    AudioStream ret = InternalHelpers.UnmanagedGetManaged(cPtr) as AudioStream;$excode
    return ret;
}

template<class AudioStream> class Ref;%template() Ref<AudioStream>;
%feature("novaluewrapper") Ref<AudioStream>;


%typemap(csbody_derived) AudioStream %{

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

%typemap(cscode) AudioStream %{
  internal $csclassname() {}

%}

%typemap(csconstruct, excode=SWIGEXCODE) AudioStream %{: this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }$excode
  }
%}

%nodefaultdtor AudioStream;

class AudioStream : public Resource {
public:
  %extend {
    ~AudioStream() {
      if ($self->get_script_instance()) {
        CSharpInstance *cs_instance = dynamic_cast<CSharpInstance*>($self->get_script_instance());
        if (cs_instance) {
          cs_instance->mono_object_disposed();
          return;
        }
      }
      if ($self->unreference()) {
        memdelete($self);
      }
    }
  }


};
