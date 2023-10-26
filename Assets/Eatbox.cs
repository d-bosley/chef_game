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
            Destroy(other.gameObject, 1f);
            Vector3 scale = player.transform.localScale;
            float radius = 5;
            scale *= 2;
            scale = Vector3.ClampMagnitude(scale, radius);
            player.transform.localScale = scale;
        }

    }
}
