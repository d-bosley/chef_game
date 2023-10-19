using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float spawnClock = 8;
    public GameObject spawnParent;
    Transform[] spawns;
    int spawnPoint;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //spawns = spawnParent.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //ClockCycle();
    }

    void ClockCycle()
    {
    
    spawnClock -= 1 * Time.deltaTime;
	if (spawnClock <= 0){
    enemyClone(1);
    spawnClock = 5;}
    }

    void enemyClone(int spawn)
    {
        GameObject enemyClone = Instantiate(enemy, spawns[spawn].position, Quaternion.identity);
    }
}
