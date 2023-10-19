using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatbox : MonoBehaviour
{
    public GameObject player;

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
        if (other.CompareTag("Enemy"))
        {
            Destroy(other, 0);
            player.transform.localScale *= 2;
        }

    }
}
