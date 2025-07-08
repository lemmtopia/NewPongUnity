using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float yBorder;

    private float yPosition;
    private Vector3 myPosition;

    void Start()
    {
        // Set myPosition to my starting position
        myPosition = transform.position;
    }

    void Update()
    {
        // Get input from the user
        if (Input.GetKey(KeyCode.W))
        {
            // Move up
            yPosition += moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Move down
            yPosition -= moveSpeed * Time.deltaTime;
        }

        // Clamp my Y position
        yPosition = Mathf.Clamp(yPosition, -yBorder, yBorder);

        // Changing my Y position
        myPosition.y = yPosition;

        // Change the Paddle position
        transform.position = myPosition;
    }
}
