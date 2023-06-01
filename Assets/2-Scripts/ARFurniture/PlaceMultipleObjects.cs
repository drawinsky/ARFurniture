using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMultipleObjects : MonoBehaviour
{
    public GameObject objectFirst, objectSecond, objectThird;
    
    private PlacementIndicator placementIndicator;
    private GameObject objectToPlace;
    private GameObject checkBeforePlace;
    private GameObject newPlacedObject;

    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    public void SetObjectToPlace(GameObject objectPrefabs)
    {
        objectToPlace = objectPrefabs;
    }

    public void ClickToPlaceFirst()
    {
        SetObjectToPlace(objectFirst);
    }
    public void ClickToPlaceSecond()
    {
        SetObjectToPlace(objectSecond);
    }
    public void ClickToPlaceThird()
    {
        SetObjectToPlace(objectThird);
    }

    public void ClickToCheck()
    {
        if (objectToPlace == null) 
        {
            return;
        }

        if (checkBeforePlace != null)
        {
            Destroy(checkBeforePlace);
        }

        checkBeforePlace = Instantiate(objectToPlace, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void ClickToPlace()
    {
        if (objectToPlace == null) 
        {
            return;
        }

        if (checkBeforePlace != null)
        {
            newPlacedObject = checkBeforePlace;
            Instantiate(newPlacedObject, checkBeforePlace.transform.position, checkBeforePlace.transform.rotation);
            Destroy(checkBeforePlace);
        }
        else
        {
            Instantiate(objectToPlace, placementIndicator.transform.position, placementIndicator.transform.rotation);
        }
    }

    public void ClickToDestroy()
    {
        if (objectToPlace == null)
        {
            return;
        }
        else
        {
            Destroy(objectToPlace);
        }

        if (checkBeforePlace != null)
        {
            Destroy(checkBeforePlace);
        }

        if (newPlacedObject != null)
        {
            Destroy(newPlacedObject);
        }
    }



    
}
