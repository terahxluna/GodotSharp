/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class HTTPClient : Reference {
  public static readonly int METHOD_GET = 0;
  public static readonly int METHOD_HEAD = 1;
  public static readonly int METHOD_POST = 2;
  public static readonly int METHOD_PUT = 3;
  public static readonly int METHOD_DELETE = 4;
  public static readonly int METHOD_OPTIONS = 5;
  public static readonly int METHOD_TRACE = 6;
  public static readonly int METHOD_CONNECT = 7;
  public static readonly int METHOD_MAX = 8;
  public static readonly int STATUS_DISCONNECTED = 0;
  public static readonly int STATUS_RESOLVING = 1;
  public static readonly int STATUS_CANT_RESOLVE = 2;
  public static readonly int STATUS_CONNECTING = 3;
  public static readonly int STATUS_CANT_CONNECT = 4;
  public static readonly int STATUS_CONNECTED = 5;
  public static readonly int STATUS_REQUESTING = 6;
  public static readonly int STATUS_BODY = 7;
  public static readonly int STATUS_CONNECTION_ERROR = 8;
  public static readonly int STATUS_SSL_HANDSHAKE_ERROR = 9;
  public static readonly int RESPONSE_CONTINUE = 100;
  public static readonly int RESPONSE_SWITCHING_PROTOCOLS = 101;
  public static readonly int RESPONSE_PROCESSING = 102;
  public static readonly int RESPONSE_OK = 200;
  public static readonly int RESPONSE_CREATED = 201;
  public static readonly int RESPONSE_ACCEPTED = 202;
  public static readonly int RESPONSE_NON_AUTHORITATIVE_INFORMATION = 203;
  public static readonly int RESPONSE_NO_CONTENT = 204;
  public static readonly int RESPONSE_RESET_CONTENT = 205;
  public static readonly int RESPONSE_PARTIAL_CONTENT = 206;
  public static readonly int RESPONSE_MULTI_STATUS = 207;
  public static readonly int RESPONSE_IM_USED = 226;
  public static readonly int RESPONSE_MULTIPLE_CHOICES = 300;
  public static readonly int RESPONSE_MOVED_PERMANENTLY = 301;
  public static readonly int RESPONSE_FOUND = 302;
  public static readonly int RESPONSE_SEE_OTHER = 303;
  public static readonly int RESPONSE_NOT_MODIFIED = 304;
  public static readonly int RESPONSE_USE_PROXY = 305;
  public static readonly int RESPONSE_TEMPORARY_REDIRECT = 307;
  public static readonly int RESPONSE_BAD_REQUEST = 400;
  public static readonly int RESPONSE_UNAUTHORIZED = 401;
  public static readonly int RESPONSE_PAYMENT_REQUIRED = 402;
  public static readonly int RESPONSE_FORBIDDEN = 403;
  public static readonly int RESPONSE_NOT_FOUND = 404;
  public static readonly int RESPONSE_METHOD_NOT_ALLOWED = 405;
  public static readonly int RESPONSE_NOT_ACCEPTABLE = 406;
  public static readonly int RESPONSE_PROXY_AUTHENTICATION_REQUIRED = 407;
  public static readonly int RESPONSE_REQUEST_TIMEOUT = 408;
  public static readonly int RESPONSE_CONFLICT = 409;
  public static readonly int RESPONSE_GONE = 410;
  public static readonly int RESPONSE_LENGTH_REQUIRED = 411;
  public static readonly int RESPONSE_PRECONDITION_FAILED = 412;
  public static readonly int RESPONSE_REQUEST_ENTITY_TOO_LARGE = 413;
  public static readonly int RESPONSE_REQUEST_URI_TOO_LONG = 414;
  public static readonly int RESPONSE_UNSUPPORTED_MEDIA_TYPE = 415;
  public static readonly int RESPONSE_REQUESTED_RANGE_NOT_SATISFIABLE = 416;
  public static readonly int RESPONSE_EXPECTATION_FAILED = 417;
  public static readonly int RESPONSE_UNPROCESSABLE_ENTITY = 422;
  public static readonly int RESPONSE_LOCKED = 423;
  public static readonly int RESPONSE_FAILED_DEPENDENCY = 424;
  public static readonly int RESPONSE_UPGRADE_REQUIRED = 426;
  public static readonly int RESPONSE_INTERNAL_SERVER_ERROR = 500;
  public static readonly int RESPONSE_NOT_IMPLEMENTED = 501;
  public static readonly int RESPONSE_BAD_GATEWAY = 502;
  public static readonly int RESPONSE_SERVICE_UNAVAILABLE = 503;
  public static readonly int RESPONSE_GATEWAY_TIMEOUT = 504;
  public static readonly int RESPONSE_HTTP_VERSION_NOT_SUPPORTED = 505;
  public static readonly int RESPONSE_INSUFFICIENT_STORAGE = 507;
  public static readonly int RESPONSE_NOT_EXTENDED = 510;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal HTTPClient(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.HTTPClient_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected HTTPClient(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.HTTPClient_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HTTPClient obj) {
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



  public int connect(string host, int port, bool use_ssl, bool verify_host) {
    int ret = GodotEnginePINVOKE.HTTPClient_connect__SWIG_0(swigCPtr, host, port, use_ssl, verify_host);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int connect(string host, int port, bool use_ssl) {
    int ret = GodotEnginePINVOKE.HTTPClient_connect__SWIG_1(swigCPtr, host, port, use_ssl);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int connect(string host, int port) {
    int ret = GodotEnginePINVOKE.HTTPClient_connect__SWIG_2(swigCPtr, host, port);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_connection(SWIGTYPE_p_RefT_StreamPeer_t connection) {
    GodotEnginePINVOKE.HTTPClient_set_connection(swigCPtr, SWIGTYPE_p_RefT_StreamPeer_t.getCPtr(connection));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_StreamPeer_t get_connection() {
    SWIGTYPE_p_RefT_StreamPeer_t ret = new SWIGTYPE_p_RefT_StreamPeer_t(GodotEnginePINVOKE.HTTPClient_get_connection(swigCPtr), true);
    return ret;
  }

  public int request_raw(int method, string url, SWIGTYPE_p_StringArray headers, SWIGTYPE_p_RawArray body) {
    int ret = GodotEnginePINVOKE.HTTPClient_request_raw(swigCPtr, method, url, SWIGTYPE_p_StringArray.getCPtr(headers), SWIGTYPE_p_RawArray.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int request(int method, string url, SWIGTYPE_p_StringArray headers, string body) {
    int ret = GodotEnginePINVOKE.HTTPClient_request__SWIG_0(swigCPtr, method, url, SWIGTYPE_p_StringArray.getCPtr(headers), body);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int request(int method, string url, SWIGTYPE_p_StringArray headers) {
    int ret = GodotEnginePINVOKE.HTTPClient_request__SWIG_1(swigCPtr, method, url, SWIGTYPE_p_StringArray.getCPtr(headers));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int send_body_text(string body) {
    int ret = GodotEnginePINVOKE.HTTPClient_send_body_text(swigCPtr, body);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int send_body_data(SWIGTYPE_p_RawArray body) {
    int ret = GodotEnginePINVOKE.HTTPClient_send_body_data(swigCPtr, SWIGTYPE_p_RawArray.getCPtr(body));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void close() {
    GodotEnginePINVOKE.HTTPClient_close(swigCPtr);
  }

  public bool has_response() {
    bool ret = GodotEnginePINVOKE.HTTPClient_has_response(swigCPtr);
    return ret;
  }

  public bool is_response_chunked() {
    bool ret = GodotEnginePINVOKE.HTTPClient_is_response_chunked(swigCPtr);
    return ret;
  }

  public int get_response_code() {
    int ret = GodotEnginePINVOKE.HTTPClient_get_response_code(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_StringArray get_response_headers() {
    SWIGTYPE_p_StringArray ret = new SWIGTYPE_p_StringArray(GodotEnginePINVOKE.HTTPClient_get_response_headers(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_Dictionary get_response_headers_as_dictionary() {
    SWIGTYPE_p_Dictionary ret = new SWIGTYPE_p_Dictionary(GodotEnginePINVOKE.HTTPClient_get_response_headers_as_dictionary(swigCPtr), true);
    return ret;
  }

  public int get_response_body_length() {
    int ret = GodotEnginePINVOKE.HTTPClient_get_response_body_length(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_RawArray read_response_body_chunk() {
    SWIGTYPE_p_RawArray ret = new SWIGTYPE_p_RawArray(GodotEnginePINVOKE.HTTPClient_read_response_body_chunk(swigCPtr), true);
    return ret;
  }

  public void set_read_chunk_size(int bytes) {
    GodotEnginePINVOKE.HTTPClient_set_read_chunk_size(swigCPtr, bytes);
  }

  public void set_blocking_mode(bool enabled) {
    GodotEnginePINVOKE.HTTPClient_set_blocking_mode(swigCPtr, enabled);
  }

  public bool is_blocking_mode_enabled() {
    bool ret = GodotEnginePINVOKE.HTTPClient_is_blocking_mode_enabled(swigCPtr);
    return ret;
  }

  public int get_status() {
    int ret = GodotEnginePINVOKE.HTTPClient_get_status(swigCPtr);
    return ret;
  }

  public int poll() {
    int ret = GodotEnginePINVOKE.HTTPClient_poll(swigCPtr);
    return ret;
  }

  public string query_string_from_dict(SWIGTYPE_p_Dictionary fields) {
    string ret = GodotEnginePINVOKE.HTTPClient_query_string_from_dict(swigCPtr, SWIGTYPE_p_Dictionary.getCPtr(fields));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HTTPClient() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_HTTPClient());
    }
  }

}

}
