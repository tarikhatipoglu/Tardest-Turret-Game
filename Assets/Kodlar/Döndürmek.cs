using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Döndürmek : MonoBehaviour
{
    public float hiz;

    void Start()
    {

    }

    void Update()
    {
        Rotate();
    }
    void Rotate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            if(transform.rotation.y > Quaternion.Euler(new Vector3(0,-90,0)).y)
            {
                transform.Rotate(0, -hiz, 0);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if(transform.rotation.y < Quaternion.Euler(new Vector3(0, 90, 0)).y)
            {
                transform.Rotate(0, hiz, 0);
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (transform.rotation.x > Quaternion.Euler(new Vector3(-30, 0, 0)).x)
            {
                transform.Rotate(-hiz, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (transform.rotation.x < Quaternion.Euler(new Vector3(30, 0, 0)).x)
            {
                transform.Rotate(hiz, 0, 0);
            }
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
    }
}
