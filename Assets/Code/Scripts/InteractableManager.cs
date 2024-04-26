using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

public class InteractableManager : MonoBehaviour
{

    private VRHandController HandColor;

    public List<GameObject> interactableObjectsRed;
    public List<GameObject> interactableObjectsGreen;
    public List<GameObject> interactableObjectsBlue;

    void Start()
    {   
        HandColor = FindAnyObjectByType<VRHandController>();

        foreach (GameObject Red in interactableObjectsRed)
        {
            Red.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        }
        foreach (GameObject Green in interactableObjectsGreen)
        {
            Green.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        }
        foreach (GameObject Blue in interactableObjectsBlue)
        {
            Blue.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        } 
    }

    void Update()
    {
        if (HandColor.currentColor == Color.red)
        {
            foreach (GameObject Red in interactableObjectsRed)
            {
                Red.gameObject.GetComponent<XRGrabInteractable>().enabled = true;
            }
            foreach (GameObject Green in interactableObjectsGreen)
            {
                Green.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            }
            foreach (GameObject Blue in interactableObjectsBlue)
            {
                Blue.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            } 
        }

                if (HandColor.currentColor == Color.green)
        {
            foreach (GameObject Red in interactableObjectsRed)
            {
                Red.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            }
            foreach (GameObject Green in interactableObjectsGreen)
            {
                Green.gameObject.GetComponent<XRGrabInteractable>().enabled = true;
            }
            foreach (GameObject Blue in interactableObjectsBlue)
            {
                Blue.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            } 
        }

                if (HandColor.currentColor == Color.blue)
        {
            foreach (GameObject Red in interactableObjectsRed)
            {
                Red.gameObject.GetComponent<XRGrabInteractable>().enabled = true;
            }
            foreach (GameObject Green in interactableObjectsGreen)
            {
                Green.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            }
            foreach (GameObject Blue in interactableObjectsBlue)
            {
                Blue.gameObject.GetComponent<XRGrabInteractable>().enabled = true;
            } 
        }
    }
}