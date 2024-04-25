using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

public class InteractableManager : MonoBehaviour
{
    public List<GameObject> interactableObjectsRed;
    public List<GameObject> interactableObjectsGreen;
    public List<GameObject> interactableObjectsBlue;

    void UpdateInteractableObjects(Color currentColor)
    {
        if (currentColor == Color.red)
        {
            SetInteractableObjects(interactableObjectsRed);
        }
        else if (currentColor == Color.green)
        {
            SetInteractableObjects(interactableObjectsGreen);
        }
        else if (currentColor == Color.blue)
        {
            SetInteractableObjects(interactableObjectsBlue);
        }
        else
        {
            // Default behavior when no gem is held
            SetInteractableObjects(null);
        }
    }

    void SetInteractableObjects(List<GameObject> objects)
    {
        // Disable interaction for all objects
        foreach (var obj in interactableObjectsRed)
        {
            obj.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        }
        foreach (var obj in interactableObjectsGreen)
        {
            obj.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        }
        foreach (var obj in interactableObjectsBlue)
        {
            obj.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        }

        // Enable interaction for objects corresponding to the held gem color
        if (objects != null)
        {
            foreach (var obj in objects)
            {
                obj.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            }
        }
    }
}