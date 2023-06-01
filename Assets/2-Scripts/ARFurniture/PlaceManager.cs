using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    private PlacementIndicator placementIndicator;
    public GameObject ObjectToPlace;
    
    private GameObject newPlacedObject;

    
    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    public void ClickToPlace()
    {
        newPlacedObject = Instantiate(ObjectToPlace, placementIndicator.transform.position, placementIndicator.transform.rotation);    
    }

}
