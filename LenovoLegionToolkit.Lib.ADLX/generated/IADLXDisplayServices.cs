//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class IADLXDisplayServices : IADLXInterface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal IADLXDisplayServices(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ADLXPINVOKE.IADLXDisplayServices_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IADLXDisplayServices obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(IADLXDisplayServices obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ADLXPINVOKE.delete_IADLXDisplayServices(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public new static SWIGTYPE_p_wchar_t IID() {
    global::System.IntPtr cPtr = ADLXPINVOKE.IADLXDisplayServices_IID();
    SWIGTYPE_p_wchar_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_wchar_t(cPtr, false);
    return ret;
  }

  public virtual ADLX_RESULT GetNumberOfDisplays(SWIGTYPE_p_unsigned_int numDisplays) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetNumberOfDisplays(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(numDisplays));
    return ret;
  }

  public virtual ADLX_RESULT GetDisplays(SWIGTYPE_p_p_adlx__IADLXDisplayList ppDisplay) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetDisplays(swigCPtr, SWIGTYPE_p_p_adlx__IADLXDisplayList.getCPtr(ppDisplay));
    return ret;
  }

  public virtual ADLX_RESULT Get3DLUT(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplay3DLUT ppDisp3DLUT) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_Get3DLUT(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplay3DLUT.getCPtr(ppDisp3DLUT));
    return ret;
  }

  public virtual ADLX_RESULT GetGamut(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayGamut ppDispGamut) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetGamut(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayGamut.getCPtr(ppDispGamut));
    return ret;
  }

  public virtual ADLX_RESULT GetGamma(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayGamma ppDispGamma) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetGamma(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayGamma.getCPtr(ppDispGamma));
    return ret;
  }

  public virtual ADLX_RESULT GetDisplayChangedHandling(SWIGTYPE_p_p_adlx__IADLXDisplayChangedHandling ppDisplayChangedHandling) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetDisplayChangedHandling(swigCPtr, SWIGTYPE_p_p_adlx__IADLXDisplayChangedHandling.getCPtr(ppDisplayChangedHandling));
    return ret;
  }

  public virtual ADLX_RESULT GetFreeSync(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayFreeSync ppFreeSync) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetFreeSync(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayFreeSync.getCPtr(ppFreeSync));
    return ret;
  }

  public virtual ADLX_RESULT GetVirtualSuperResolution(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayVSR ppVSR) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetVirtualSuperResolution(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayVSR.getCPtr(ppVSR));
    return ret;
  }

  public virtual ADLX_RESULT GetGPUScaling(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayGPUScaling ppGPUScaling) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetGPUScaling(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayGPUScaling.getCPtr(ppGPUScaling));
    return ret;
  }

  public virtual ADLX_RESULT GetScalingMode(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayScalingMode ppScalingMode) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetScalingMode(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayScalingMode.getCPtr(ppScalingMode));
    return ret;
  }

  public virtual ADLX_RESULT GetIntegerScaling(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayIntegerScaling ppIntegerScaling) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetIntegerScaling(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayIntegerScaling.getCPtr(ppIntegerScaling));
    return ret;
  }

  public virtual ADLX_RESULT GetColorDepth(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayColorDepth ppColorDepth) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetColorDepth(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayColorDepth.getCPtr(ppColorDepth));
    return ret;
  }

  public virtual ADLX_RESULT GetPixelFormat(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayPixelFormat ppPixelFormat) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetPixelFormat(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayPixelFormat.getCPtr(ppPixelFormat));
    return ret;
  }

  public virtual ADLX_RESULT GetCustomColor(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayCustomColor ppCustomColor) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetCustomColor(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayCustomColor.getCPtr(ppCustomColor));
    return ret;
  }

  public virtual ADLX_RESULT GetHDCP(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayHDCP ppHDCP) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetHDCP(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayHDCP.getCPtr(ppHDCP));
    return ret;
  }

  public virtual ADLX_RESULT GetCustomResolution(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayCustomResolution ppCustomResolution) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetCustomResolution(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayCustomResolution.getCPtr(ppCustomResolution));
    return ret;
  }

  public virtual ADLX_RESULT GetVariBright(IADLXDisplay pDisplay, SWIGTYPE_p_p_adlx__IADLXDisplayVariBright ppVariBright) {
    ADLX_RESULT ret = (ADLX_RESULT)ADLXPINVOKE.IADLXDisplayServices_GetVariBright(swigCPtr, IADLXDisplay.getCPtr(pDisplay), SWIGTYPE_p_p_adlx__IADLXDisplayVariBright.getCPtr(ppVariBright));
    return ret;
  }

}
