using UnityEngine;

public class MametchiController : MonoBehaviour
{
    public float walkSpeed = 2f;
    public float turnSpeed = 90f;

    private void Update()
    {
        // Implement walking logic here
        Walk();
    }

    private void Walk()
    {
        // Move forward
        transform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);

        // Rotate randomly
        if (Random.value < 0.02f) // 2% chance to turn each frame
        {
            float turnAmount = Random.Range(-1f, 1f);
            transform.Rotate(Vector3.up, turnAmount * turnSpeed * Time.deltaTime);
        }
    }
}
