using System.Runtime.InteropServices;
using UnityEngine;

public class JSInteropExample : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void StartPayHerePayment();
#endif

    public void StartPayment()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        StartPayHerePayment();
#else
        Debug.Log("PayHere can only be triggered in WebGL builds");
#endif
    }
}
