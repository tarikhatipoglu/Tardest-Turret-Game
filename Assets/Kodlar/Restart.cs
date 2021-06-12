using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public float gerisayim=2;
    public string YeniLevel = "Main";
    void Start()
    {
        
    }

    void Update()
    {
        if(gerisayim > 0)
        {
            gerisayim -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(YeniLevel);
        }
    }
}
