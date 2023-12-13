using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class SpawnerButton : MonoBehaviour
{
    public Spawner spawnScript;
    public GameObject enemy;
    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            for(int i = 0; i < 4; i++)
            {
                spawnScript.enemyClone(i, parent);
            }
            
            //spawnScript.enemyClone(1);
        }
    }
}