using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    [SerializeField] private Color[] allColors;

    private Color startColor;

    private int colorIndex = 0;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        startColor = allColors[colorIndex];
    }
    void Start()
    {
        meshRenderer.material.color = startColor;
    }

    void Update()
    {
        
    }

    public void ChangeColor()
    {

    }
}
