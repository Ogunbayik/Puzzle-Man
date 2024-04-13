using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ColorChanger : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    [SerializeField] private Button testButton;

    [SerializeField] private Button changerButton;

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
        

        ChangerButtonActivate(false);
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
            ChangerButtonActivate(true);

        changerButton.onClick.AddListener(ChangePlayerColor);
    }

    private void OnTriggerExit(Collider other)
    {
        player = null;
        buttonImage.color = Color.white;
        outlineImage.color = Color.white;

        changerButton.onClick.RemoveListener(ChangePlayerColor);
        ChangerButtonActivate(false);
    }

    private void ChangerButtonActivate(bool isActive)
    {
        changerButton.gameObject.SetActive(isActive);
        outlineImage.gameObject.SetActive(isActive);
    }

    private void ChangePlayerColor()
    {
        player.ChangeColor(colorName,changerColor);
    }
}
