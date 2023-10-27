using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    Vector3 here;
    Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        here = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SetMovementDestination(here, out Vector3 finalPlace);
        destination = finalPlace;
        transform.position = Vector3.MoveTowards(transform.position, destination, .35f);
    }

    void SetMovementDestination(Vector3 initialPosition, out Vector3 newPosition)
    {
        float amplitude = .15f; // The distance the object moves from its starting position
        float frequency = 1.0f; // The speed of the back-and-forth motion

        // Calculate the new position based on a sine wave
        float yOffset = amplitude * Mathf.Sin(Time.time * frequency);

        // Update the object's position to move back and forth along the x-axis
        newPosition = initialPosition + (Vector3.up * yOffset);
    }
}