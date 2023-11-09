using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crack : MonoBehaviour
{
    public GameObject crackedCube;

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(crackedCube, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
