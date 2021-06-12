using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject HedefPrefab;
    public GameObject SpawnArea;
    public int miktar = 5;
    int countdown;
    
    void Start()
    {
        Kazandiniz();
        for(countdown=5; countdown>0; countdown--)
        {
            SpawningObjects();
        }
    }

    void Update()
    {
        Kazandiniz();
    }

    void SpawningObjects()
    {
        Vector3 pos;
        pos = new Vector3(Random.Range(-6f, 6f), Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        pos = transform.TransformPoint(pos);
        Instantiate(HedefPrefab, pos, Quaternion.Euler(0,-180,0));
    }

    void Kazandiniz()
    {
        MermiSayisi.Miktar = miktar;
    }
}
