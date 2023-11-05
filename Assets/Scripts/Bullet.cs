using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}