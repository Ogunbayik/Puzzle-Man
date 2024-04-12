using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    [SerializeField] private GameObject changerButton;

    [SerializeField] private string colorName;
    [SerializeField] private Color changerColor;
    [SerializeField] private Color outlineColor;

    [SerializeField] private Image buttonImage;
    [SerializeField] private Image outlineImage;

    private PlayerColorManager player;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        player = null;
    }

    void Start()
    {
        changerButton.SetActive(false);
        meshRenderer.material.color = changerColor;
        buttonImage.color = changerColor;
        outlineImage.color = outlineColor;
    }

    private void OnTriggerEnter(Collider other)
    {
         player = other.gameObject.GetComponent<PlayerColorManager>();

        buttonImage.color = changerColor;
        outlineImage.color = outlineColor;
    }

    private void OnTriggerStay(Collider other)
    {
        if (player != null)
            changerButton.SetActive(true);

        //Show Changer Button
    }

    private void OnTriggerExit(Collider other)
    {
        player = null;
        buttonImage.color = Color.white;
        outlineImage.color = Color.white;

        changerButton.SetActive(false);
    }
}
