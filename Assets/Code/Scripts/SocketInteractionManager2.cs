using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketInteractionManager2 : MonoBehaviour
{
    private IXRSelectInteractable item;
    private bool IsShield;
    private bool IsAxe;

    // Start is called before the first frame update
    void Update()
    {
        
    }

    public void ShieldCheck()
    {
        GameObject item = GetComponent<XRSocketInteractor>().selectTarget.gameObject;
        if (item.CompareTag("Shield"))
        {
            IsShield = true;
        }
    }

    public void ShieldSocketItemRemoved()
    {
        item = null;
        IsShield = false;
    }

    public void AxeCheck()
    {
        GameObject item = GetComponent<XRSocketInteractor>().selectTarget.gameObject;
        if(item.CompareTag("Axe"))
        {
            IsAxe = true;
        }
    }

    public void AxeSocketItemRemoved()
    {
        item = null;
        IsAxe = false;
    }
}
