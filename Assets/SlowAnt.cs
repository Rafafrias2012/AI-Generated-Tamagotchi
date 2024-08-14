using UnityEngine;

public class SlowAnt : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float rotationSpeed = 10f;
    public float changeDirectionInterval = 5f;

    private Vector3 randomDirection;
    private float timeSinceLastDirectionChange;

    void Start()
    {
        // Initialize the random direction
        ChangeDirection();
    }

    void Update()
    {
        // Move the ant
        transform.Translate(randomDirection * moveSpeed * Time.deltaTime);

        // Rotate the ant towards the movement direction
        Quaternion targetRotation = Quaternion.LookRotation(randomDirection);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        // Change direction periodically
        timeSinceLastDirectionChange += Time.deltaTime;
        if (timeSinceLastDirectionChange >= changeDirectionInterval)
        {
            ChangeDirection();
            timeSinceLastDirectionChange = 0f;
        }
    }

    void ChangeDirection()
    {
        // Generate a random direction on the XZ plane
        randomDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }
}
