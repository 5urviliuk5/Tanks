using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 90;
    public KeyCode shootKey;
    public string vertical;
    public string horizontal;
    public GameObject bullet;
    public Transform shootPoint;
    public AudioSource shoot;

    void Update()
    {
        var ver = Input.GetAxis(vertical);
        GetComponent<Rigidbody>().velocity = transform.forward * speed * ver;

        var hor = Input.GetAxis(horizontal);
        transform.Rotate(0, rotateSpeed * hor * Time.deltaTime, 0);

        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
            shoot.Play();
        }
    }
}
