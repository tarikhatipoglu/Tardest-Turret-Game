using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MermiSayisi : MonoBehaviour
{
    private Text txtMe;
    public static int Cephane;
    public static int Miktar;
    public int C, M;

    void Start()
    {
        txtMe = GetComponent<Text>();

        if (C == 0 && M > 0)
        {
            Debug.Log("Oyunu kaybettiniz!");
        }
        else if (M == 0 && C > 0)
        {
            Debug.Log("Oyunu kazandınız!");
        }
    }

    void Update()
    {
        C = Cephane;
        M = Miktar;
        txtMe.text = "Mermi: " + C;
    }
}
