using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    public float hiz = 7f;
    public GameObject bulletHit;
    private AudioSource mSesMermi;
    void Start()
    {
        mSesMermi = GetComponent<AudioSource>();
    }

    void Update()
    {
        Destroy(gameObject, 5f);
        transform.position += transform.forward * hiz * Time.deltaTime;
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Target")
        {
            MermiSayisi.Miktar -= 1;
            mSesMermi.Play();
            Instantiate(bulletHit, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Building")
        {
            MermiSayisi.Miktar -= 1;
            mSesMermi.Play();
            Instantiate(bulletHit, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
