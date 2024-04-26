using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRHandController : MonoBehaviour
{
    public Material defaultHandMaterial;
    public Renderer handRenderer;

    public Color currentColor;

    void Start()
    {
        // Initialize hand color to default
        SetHandColor(Color.white);
    }

    void SetHandColor(Color color)
    {
        handRenderer.material.color = color;
        currentColor = color;
    }

    void OnTriggerEnter(Collider other)
    {
        Gem gem = other.GetComponent<Gem>();
        if (gem != null)
        {
            SetHandColor(gem.gemColor);
        }
    }
}