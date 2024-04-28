using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleSocketScript : MonoBehaviour
{
    private IXRSelectInteractable item;
    public GameObject SocketManager;

    public void ItemAdded_01()
    {
        item = GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();
        SocketManager.GetComponent<SocketInteractionManager>().Puzzle_1_Count += 1;
    }

    public void ItemRemoved_01()
    {
        item = GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();
        SocketManager.GetComponent<SocketInteractionManager>().Puzzle_1_Count += 1;
    }

    public void ItemAdded_02()
    {
        item = GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();
        SocketManager.GetComponent<SocketInteractionManager>().Puzzle_2_Count += 1;
    }

    public void ItemRemoved_02()
    {
        item = null;
        SocketManager.GetComponent<SocketInteractionManager>().Puzzle_2_Count -= 1;
    }
}
