using System.Runtime.InteropServices;
using UnityEngine;

public class PaymentController : MonoBehaviour
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

//     [DllImport("__Internal")]
    //     private static extern void initPayment(string merchantId, string merchantSecret,
    //         string amount, string currency, string customerName,
    //         string customerEmail, string orderId, string returnUrl, string cancelUrl);

    //     public UIManager uiManager;

    //     // Hardcoded values as per requirements
    //     private string merchantId = "123654";
    //     private string merchantSecret = "87654321";
    //     private string amount = "1000.00";
    //     private string currency = "LKR";
    //     private string customerName = "Test Customer";
    //     private string customerEmail = "test@example.com";
    //     private string returnUrl = ""; // Current page
    //     private string cancelUrl = ""; // Current page

    //     public void InitiatePayment()
    //     {
    //         string orderId = System.Guid.NewGuid().ToString();

    // #if UNITY_WEBGL && !UNITY_EDITOR
    //         initPayment(merchantId, merchantSecret, amount, currency, 
    //                   customerName, customerEmail, orderId, returnUrl, cancelUrl);
    // #else
    //         UnityEngine.Debug.Log("Payment would be initiated here in WebGL build");
    //         // Simulate success for testing in editor
    //         uiManager.UpdateStatus("Payment successful (Simulated in Editor)");
    // #endif
    //     }

    //     public void OnPaymentSuccess(string orderId)
    //     {
    //         uiManager.UpdateStatus($"Payment successful! Order ID: {orderId}");
    //     }

    //     public void OnPaymentFailed(string error)
    //     {
    //         uiManager.UpdateStatus($"Payment failed: {error}");
    //     }

    //     public void OnPaymentDismissed(string message)
    //     {
    //         uiManager.UpdateStatus("Payment was cancelled");
    //     }
}