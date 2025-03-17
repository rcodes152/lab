using UnityEngine;

public class PlayerFPC : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get movement input
        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");

        // Move the character
        Vector3 move = transform.forward * moveZ + transform.right * moveX;
        controller.Move(move * speed * Time.deltaTime);

        // Get mouse input for rotation
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0); // Fixed the typo
    }
}
