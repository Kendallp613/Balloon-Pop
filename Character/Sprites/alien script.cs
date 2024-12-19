using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    public float moveSpeed = 2f;         // Speed at which the alien moves
    public float moveDistance = 5f;      // Distance the alien moves before reversing direction
    private Vector3 startingPosition;    // The starting position of the alien
    private bool movingRight = true;     // Direction flag

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;  // Store the initial position
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the target position based on the moveDistance
        float targetPositionX = movingRight ? startingPosition.x + moveDistance : startingPosition.x - moveDistance;

        // Move the alien back and forth between the starting position and the target position
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetPositionX, transform.position.y, transform.position.z), moveSpeed * Time.deltaTime);

        // Check if the alien has reached the target position and reverse direction
        if (transform.position.x == targetPositionX)
        {
            movingRight = !movingRight;  // Reverse direction
        }
    }
}
