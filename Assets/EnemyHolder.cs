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
    float spawnTimer = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer -= 1 * Time.Time;

        if(spawnTimer >= 0)
        {
        for(int i = 0; i < maxEnemy; i++)
        {
            spawnScript.enemyClone(i, parent);
            Debug.Log("Enemy " + i + " has spawned");
        }
        spawnTimer = 10;
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
        currentEnemies = parent.childCount;

        if(currentEnemies < maxEnemy)
        {
            spawnTimer -= 1 * Time.time;
            if(spawnTimer <=0)
            {
            int enemyCheck = currentEnemies + 1; 
            spawnScript.enemyClone(enemyCheck, parent);
            spawnTimer = 10;
            }
        }

        Debug.Log(currentEnemies);

    }
}
