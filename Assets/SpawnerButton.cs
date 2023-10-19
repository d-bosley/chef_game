using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class SpawnerButton : MonoBehaviour
{
    public Spawner spawnScript;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        spawnScript.enemyClone(1);
        Debug.Log("PressedIt");
    }
}