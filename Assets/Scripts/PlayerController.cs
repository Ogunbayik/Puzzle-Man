using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string HORIZONTAL_INPUT = "Horizontal";
    private const string VERTICAL_INPUT = "Vertical";

    [SerializeField] private float movementSpeed;


    private Vector3 movementDirection;
    void Start()
    {
        
    }


    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        var horizontal = Input.GetAxis(HORIZONTAL_INPUT);
        var vertical = Input.GetAxis(VERTICAL_INPUT);

        movementDirection = new Vector3(horizontal, 0f, vertical);
        movementDirection.Normalize();

        transform.position += movementDirection * movementSpeed * Time.deltaTime;
    }
}
