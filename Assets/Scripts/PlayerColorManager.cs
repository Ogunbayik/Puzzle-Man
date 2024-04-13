using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    [SerializeField] private Color startColor;

    private string colorName;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    void Start()
    {
        meshRenderer.material.color = startColor;
    }

    void Update()
    {
        
    }

    public void ChangeColor(string name, Color color)
    {
        meshRenderer.material.color = color;
        colorName = name;
    }
}
