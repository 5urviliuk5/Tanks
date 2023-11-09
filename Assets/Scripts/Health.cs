using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject particle;

    public void Die()
    {
        Destroy(gameObject);  
        for (int i = 0; i < 5; i++)
        {
            Instantiate(particle, transform.position, transform.rotation);
        }
    }

    void Update()
    {
        
    }
}
