using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hedef : MonoBehaviour
{
    public GameObject comingbullet;
    Rigidbody rig;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            rig.useGravity = true;
            Destroy(gameObject, 7f);
        }
    }
}
