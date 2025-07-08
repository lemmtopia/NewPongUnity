using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] float xBorder;

    [SerializeField] AudioSource boingSound;

    [SerializeField] float delay = 2f;

    private bool isMoving;
    private Vector2 startVelocity;

    void Start()
    {
        // Set a random velocity (if it is (0, 0) , default to (1, 1))
        int xRandom = Random.Range(-1, 1);
        int yRandom = Random.Range(-1, 1);
        startVelocity.x = (xRandom != 0) ? (float)xRandom : 1f;
        startVelocity.y = (yRandom != 0) ? (float)yRandom : 1f;

        // Will not move
    }

    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0 && !isMoving)
        {
            // Set velocity to the left
            rb.linearVelocity = startVelocity.normalized * moveSpeed;

            // Move
            isMoving = true;
        }

        if (transform.position.x > xBorder || transform.position.x < -xBorder)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        boingSound.Play();
    }
}
