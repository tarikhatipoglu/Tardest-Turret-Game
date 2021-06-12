using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silah_KolayMod : MonoBehaviour
{
    public GameObject fireposition;
    public GameObject bullet;
    private AudioSource mSesSilah;

    void Start()
    {
        mSesSilah = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mSesSilah.Play();
            GameObject bulletObjesi = Instantiate(bullet);
            bulletObjesi.transform.position = fireposition.transform.position + fireposition.transform.forward;
            bulletObjesi.transform.forward = fireposition.transform.forward;
        }
    }
}
