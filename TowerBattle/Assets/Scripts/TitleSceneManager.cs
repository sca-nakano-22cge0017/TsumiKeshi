﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}