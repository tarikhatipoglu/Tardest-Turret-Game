using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silah_ZorMod : MonoBehaviour
{
    public GameObject fireposition;
    public GameObject bullet;
    private AudioSource mSesSilah;
    public int cephanEE = 10;

    void Start()
    {
        mSesSilah = GetComponent<AudioSource>();
    }

    void Update()
    {
        MermiSayisi.Cephane = cephanEE;
        if (Input.GetMouseButtonDown(0) && cephanEE != 0)
        {
            cephanEE -= 1;
            MermiSayisi.Cephane -= 1;
            mSesSilah.Play();
            GameObject bulletObjesi = Instantiate(bullet);
            bulletObjesi.transform.position = fireposition.transform.position + fireposition.transform.forward;
            bulletObjesi.transform.forward = fireposition.transform.forward;
        }

        else if(cephanEE == 0)
        {
            Debug.Log("You lost");
        }
    }
}
