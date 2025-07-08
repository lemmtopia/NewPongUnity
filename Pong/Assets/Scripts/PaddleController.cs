using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float yBorder;
    [SerializeField] private bool isPlayer1;

    private float yPosition;
    private Vector3 myPosition;
    
    KeyCode keyUp;
    KeyCode keyDown;

    void Start()
    {
        // Set myPosition to my starting position
        myPosition = transform.position;

        // Keys
        if (isPlayer1)
        {
            keyUp = KeyCode.W;
            keyDown = KeyCode.S;
        }
        else
        {
            keyUp = KeyCode.UpArrow;
            keyDown = KeyCode.DownArrow;
        }
    }

    void Update()
    {
        // Get input from the user
        if (Input.GetKey(keyUp))
        {
            // Move up
            yPosition += moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(keyDown))
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
