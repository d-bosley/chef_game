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
        for(int i = 0; i < maxEnemy; i++)
        {
            spawnScript.enemyClone(i);
            //enemyClone.transform.parent = parent;
        }

        children = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            children[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentEnemies = children.Length;

        if(currentEnemies < maxEnemy)
        {
            int enemyCheck = currentEnemies + 1; 
            spawnScript.enemyClone(enemyCheck);
            currentEnemies += 1;
        }
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
