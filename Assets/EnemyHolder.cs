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
        float spawnTimer = 5;
        spawnTimer -= 1 * Time.deltaTime;

        if(spawnTimer >= 0)
        {
        for(int i = 0; i < maxEnemy; i++)
        {
            spawnScript.enemyClone(i, parent);
            Debug.Log("Enemy " + i + " has spawned");
        }
        spawnTimer = 1;
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
            int enemyCheck = currentEnemies + 1; 
            spawnScript.enemyClone(enemyCheck, parent);
        }

        Debug.Log(currentEnemies);
    }
}
