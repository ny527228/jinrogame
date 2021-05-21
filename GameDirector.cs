using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGage;

    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
    }

    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
        if (hpGage.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("clearScene");

        }
    }

    public void IncreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount += 0.1f;
    }

    void Update()
    {
        
    }

}
