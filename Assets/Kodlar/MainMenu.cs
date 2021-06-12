using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mm;
    public GameObject zs;
    void Start()
    {
        mm.SetActive(true);
        zs.SetActive(false);
    }

    public void Easy()
    {
        SceneManager.LoadScene("Sahne_Kolay");
    }
    public void Hard()
    {
        SceneManager.LoadScene("Sahne_Zor");
    }
    public void Exit()
    {
        Debug.Log("Çıkış yapıldı");
        Application.Quit();
    }
    public void Geri()
    {

    }
    public void Oyna()
    {

    }
}
