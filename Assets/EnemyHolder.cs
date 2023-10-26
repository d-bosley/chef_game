using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHolder : MonoBehaviour
{
    public Spawner spawnScript;
    public Transform parent;
    public GameObject enemy;
    public int maxEnemy = 4;
    private Transform[] children;
    private int currentEnemies;

    // Start is called before the first frame update
    void Start()
    {
        int spawnTimer = 5;
        spawnTimer -= Time.Time;

        if(spawnTimer >= 0)
        {
        for(int i = 0; i < maxEnemy; i++)
        {
            spawnScript.enemyClone(i, parent);
            Debug.Log("Enemy " + i + " has spawned");
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //children = new Transform[transform.childCount];
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    children[i] = transform.GetChild(i);
        //}

        //currentEnemies = children.Length;
        
        currentEnemies = transform.childCount;

        if(currentEnemies < maxEnemy)
        {
            int enemyCheck = currentEnemies + 1; 
            spawnScript.enemyClone(enemyCheck, parent);
        }

        Debug.Log(currentEnemies);
    }

    void OnTriggerEnter(Collider other)
    {
//        if(other.CompareTag("Player"))
//        {
//            for(int i = 0; i < 4; i++)
//            {
//                spawnScript.enemyClone(i);
//                enemyClone.transform.parent = parent;
//            }
//        }
    }
}
