using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveSpeedAI = 2.5f;
    [SerializeField] private float yBorder;
    [SerializeField] private bool isPlayer1;
    [SerializeField] private bool isAIControlled;
    [SerializeField] private Transform ballTransform;

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
        if (!isPlayer1)
        {
            if (Input.GetKey(keyUp) || Input.GetKey(keyDown))
            {
                isAIControlled = false;
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                isAIControlled = true;
            }
        }

        if (isAIControlled)
        {
            yPosition = Mathf.Lerp(yPosition, ballTransform.position.y, moveSpeedAI * Time.deltaTime);   
        }
        else
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
        }

        // Clamp my Y position
        yPosition = Mathf.Clamp(yPosition, -yBorder, yBorder);

        // Changing my Y position
        myPosition.y = yPosition;

        // Change the Paddle position
        transform.position = myPosition;
    }
}
