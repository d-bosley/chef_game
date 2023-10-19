using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    [HideInInspector] public Vector3 destination;
    public Transform[] waypoints;
    public Collider hitbox;
    public bool aggressive = false;
    Vector3 here;
    int m_WaypointIndex;

    // Start is called before the first frame update
    void Start()
    {
        //navMeshAgent.SetDestination(destination);
        //navMeshAgent.SetDestination(waypoints[0].position);
        bool aggressive = false;
        here = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(destination);

        if(!aggressive)
        {
            //SetMovementDestination(here, out Vector3 finalPlace);
            //destination = finalPlace;
            //transform.position = Vector3.Lerp(here, destination, .5f);
        }

        //if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        //{
        //    m_WaypointIndex = (m_WaypointIndex + 1) % waypoints.Length;
        //    navMeshAgent.SetDestination(waypoints[m_WaypointIndex].position);
        //}
    }

    void SetMovementDestination(Vector3 initialPosition, out Vector3 newPosition)
    {
        float amplitude = 5.0f; // The distance the object moves from its starting position
        float frequency = 1.0f; // The speed of the back-and-forth motion

        // Calculate the new position based on a sine wave
        float xOffset = amplitude * Mathf.Sin(Time.time * frequency);

        // Update the object's position to move back and forth along the x-axis
        newPosition = initialPosition + (Vector3.right * xOffset);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aggressive = true;
            destination = other.transform.position;
        }

    }
}