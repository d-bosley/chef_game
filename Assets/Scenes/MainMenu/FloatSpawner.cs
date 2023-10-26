using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatSpawner : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    private void Update()
    {
        
    }

    void spawnSomethingAwesomePlease()
    {
        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
    }
}
