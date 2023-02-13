using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // the speed of the player

    private Rigidbody2D rigidBody;
    private Vector2 movement;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get input for movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Set the movement vector
        movement = new Vector2(horizontal, vertical);

        // Normalize the movement vector so the player moves at a constant speed
        movement = movement.normalized * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        // Move the rigidbody using the movement vector
        rigidBody.MovePosition(rigidBody.position + movement);
    }
}
