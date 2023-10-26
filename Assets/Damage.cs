using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    bool larger = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    larger = player.transform.localScale.magnitude > 1 : true ? false;
    }

    void OnCollisionStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (!larger)
            {
            // Show death screen
            }
            
            else
            {
            Vector3 scale = player.transform.localScale;
            float shrink = Vector3.one * 1.5f;
            scale -= shrink;
            player.transform.localScale = scale;
            }
        }

    }
}
