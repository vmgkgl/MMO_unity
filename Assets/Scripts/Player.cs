using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = 0.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 horizontalInput = new Vector3(-Input.GetAxis("Horizontal"), 0.0f, -Input.GetAxis("Vertical"));
        Vector3 horizontalDirection = transform.TransformDirection(horizontalInput);
        moveDirection = horizontalDirection * speed;

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}