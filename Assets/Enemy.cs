using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [HideInInspector] public Vector3 destination;
    [HideInInspector] public Transform movezone;
    public Collider hitbox;
    public bool aggressive = false;
    Vector3 here;
    Rigidbody enemy;
    public Transform[] waypoints;
    int m_WaypointIndex;
    public Transform wanderingArea; // The center of the wandering area
    public float wanderRadius = 10f; // Radius within the wandering area
    public float wanderInterval = 5f; // Time between wander movements
    public NavMeshAgent navmesh;
    private Vector3 randomDestination;
    private float lastWanderTime;

    // Start is called before the first frame update
    void Start()
    {
        bool aggressive = false;
        here = transform.position;
        lastWanderTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(!aggressive)
        {
//            if (Time.time - lastWanderTime >= wanderInterval)
//            {
//                Wander();
//            }
            SetMovementDestination(here, out Vector3 finalPlace);
            destination = finalPlace;
            transform.position = Vector3.MoveTowards(transform.position, destination, .35f);
        }
    }

    void Wander()
    {
        RandomNavCube(wanderingArea.position, wanderRadius, -1, out randomDestination);
        navmesh.SetDestination(randomDestination);
        lastWanderTime = Time.time;
    }

    void ChasePlayer()
    {
        navMeshAgent.SetDestination(player.position);
    }

    void StopChasingPlayer()
    {
        Vector3 moveAway = transform.position - (player.position - transform.position).normalized;
        navMeshAgent.SetDestination(moveAway);
    }

    static void RandomNavCube(Vector3 origin, float distance, int layerMask, out Vector3 destination)
    {
        Vector3 randomDirection = Random.insideUnitSphere * distance;
        randomDirection += origin;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, distance, layerMask);
        destination = hit.position;
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
//        if(other.CompareTag("Player"))
//        {
//            aggressive = true;
//            destination = other.transform.position;
//        }
    }

        void OnTriggerExit(Collider other)
    {
//        if(other.CompareTag("Player"))
//        {
//            aggressive = false;
//            destination = destination;
//        }
    }
}