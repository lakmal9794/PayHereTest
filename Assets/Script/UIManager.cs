using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button payButton;
    public Text statusText;

    public void Start()
    {
        payButton.onClick.AddListener(OnPayButtonClicked);
    }

    public void OnPayButtonClicked()
    {
        statusText.text = "Initializing payment...";
        //Payment initiation will be handled here
    }

    public void UpdateStatus(string message)
    {
        statusText.text = message;
    }

}
