//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CallInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CallInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CallInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CallInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_CallInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_pjsua_call_id id {
    set {
      pjsua2PINVOKE.CallInfo_id_set(swigCPtr, SWIGTYPE_p_pjsua_call_id.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsua_call_id ret = new SWIGTYPE_p_pjsua_call_id(pjsua2PINVOKE.CallInfo_id_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pjsip_role_e role {
    set {
      pjsua2PINVOKE.CallInfo_role_set(swigCPtr, SWIGTYPE_p_pjsip_role_e.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsip_role_e ret = new SWIGTYPE_p_pjsip_role_e(pjsua2PINVOKE.CallInfo_role_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pjsua_acc_id accId {
    set {
      pjsua2PINVOKE.CallInfo_accId_set(swigCPtr, SWIGTYPE_p_pjsua_acc_id.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsua_acc_id ret = new SWIGTYPE_p_pjsua_acc_id(pjsua2PINVOKE.CallInfo_accId_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string localUri {
    set {
      pjsua2PINVOKE.CallInfo_localUri_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.CallInfo_localUri_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string localContact {
    set {
      pjsua2PINVOKE.CallInfo_localContact_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.CallInfo_localContact_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string remoteUri {
    set {
      pjsua2PINVOKE.CallInfo_remoteUri_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.CallInfo_remoteUri_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string remoteContact {
    set {
      pjsua2PINVOKE.CallInfo_remoteContact_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.CallInfo_remoteContact_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string callIdString {
    set {
      pjsua2PINVOKE.CallInfo_callIdString_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.CallInfo_callIdString_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public CallSetting setting {
    set {
      pjsua2PINVOKE.CallInfo_setting_set(swigCPtr, CallSetting.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.CallInfo_setting_get(swigCPtr);
      CallSetting ret = (cPtr == global::System.IntPtr.Zero) ? null : new CallSetting(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_pjsip_inv_state state {
    set {
      pjsua2PINVOKE.CallInfo_state_set(swigCPtr, SWIGTYPE_p_pjsip_inv_state.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsip_inv_state ret = new SWIGTYPE_p_pjsip_inv_state(pjsua2PINVOKE.CallInfo_state_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string stateText {
    set {
      pjsua2PINVOKE.CallInfo_stateText_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.CallInfo_stateText_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pjsip_status_code lastStatusCode {
    set {
      pjsua2PINVOKE.CallInfo_lastStatusCode_set(swigCPtr, SWIGTYPE_p_pjsip_status_code.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsip_status_code ret = new SWIGTYPE_p_pjsip_status_code(pjsua2PINVOKE.CallInfo_lastStatusCode_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string lastReason {
    set {
      pjsua2PINVOKE.CallInfo_lastReason_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.CallInfo_lastReason_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t media {
    set {
      pjsua2PINVOKE.CallInfo_media_set(swigCPtr, SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.CallInfo_media_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t provMedia {
    set {
      pjsua2PINVOKE.CallInfo_provMedia_set(swigCPtr, SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.CallInfo_provMedia_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_pj__CallMediaInfo_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_TimeVal connectDuration {
    set {
      pjsua2PINVOKE.CallInfo_connectDuration_set(swigCPtr, SWIGTYPE_p_TimeVal.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_TimeVal ret = new SWIGTYPE_p_TimeVal(pjsua2PINVOKE.CallInfo_connectDuration_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_TimeVal totalDuration {
    set {
      pjsua2PINVOKE.CallInfo_totalDuration_set(swigCPtr, SWIGTYPE_p_TimeVal.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_TimeVal ret = new SWIGTYPE_p_TimeVal(pjsua2PINVOKE.CallInfo_totalDuration_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool remOfferer {
    set {
      pjsua2PINVOKE.CallInfo_remOfferer_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.CallInfo_remOfferer_get(swigCPtr);
      return ret;
    } 
  }

  public uint remAudioCount {
    set {
      pjsua2PINVOKE.CallInfo_remAudioCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CallInfo_remAudioCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint remVideoCount {
    set {
      pjsua2PINVOKE.CallInfo_remVideoCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CallInfo_remVideoCount_get(swigCPtr);
      return ret;
    } 
  }

  public void fromPj(SWIGTYPE_p_pjsua_call_info pci) {
    pjsua2PINVOKE.CallInfo_fromPj(swigCPtr, SWIGTYPE_p_pjsua_call_info.getCPtr(pci));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public CallInfo() : this(pjsua2PINVOKE.new_CallInfo(), true) {
  }

}
