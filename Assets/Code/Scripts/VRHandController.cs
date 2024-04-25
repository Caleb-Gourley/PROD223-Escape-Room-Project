using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHandController : MonoBehaviour
{
    public Material defaultHandMaterial;
    public Renderer handRenderer;

    private Color currentColor;

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