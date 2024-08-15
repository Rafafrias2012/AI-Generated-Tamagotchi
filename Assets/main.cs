using UnityEngine;

public class MametchiController : MonoBehaviour
{
    public float groundOffset = 0f; // Adjust this value to fine-tune Mametchi's position above the ground

    private void Start()
    {
        // Position Mametchi on the ground
        PositionOnGround();
    }

    private void PositionOnGround()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up * 10f, Vector3.down, out hit, Mathf.Infinity))
        {
            transform.position = hit.point + Vector3.up * groundOffset;
        }
    }
}
