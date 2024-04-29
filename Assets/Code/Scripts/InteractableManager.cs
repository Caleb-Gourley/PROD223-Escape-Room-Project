using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableManager : MonoBehaviour
{

    private VRHandController HandColor;

    public List<GameObject> interactableObjectsRed;
    public List<GameObject> interactableObjectsGreen;
    public List<GameObject> interactableObjectsBlue;

    public SocketInteractionManager Red_Counter;

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
            if (Red_Counter.Puzzle_2_Count != 2)
            {
                foreach (GameObject Red in interactableObjectsRed)
                {
                    Red.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
                }
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
            if (Red_Counter.Puzzle_2_Count != 2)
            {
                foreach (GameObject Red in interactableObjectsRed)
                {
                    Red.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
                }
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