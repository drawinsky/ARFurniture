using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour

{
    public Button button;
    public GameObject visualObject;
    public PlaceOnPlane placeOnPlaneScript;

    
    private void Start()
    {
        visualObject.SetActive(false);
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        visualObject.SetActive(true);
        placeOnPlaneScript.PerformARRaycast();
    }
}