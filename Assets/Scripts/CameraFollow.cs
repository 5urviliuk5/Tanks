using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Transform target2;

    void Start()
    {
        
    }

    void Update()
    {
        var pos = Vector3.Lerp(target.position, target2.position, 0.5f);
        transform.position = Vector3.MoveTowards(transform.position, pos, 0.01f);
    }
}
