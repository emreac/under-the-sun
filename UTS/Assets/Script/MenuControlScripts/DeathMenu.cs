﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DeathMenu : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {


        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ToggleEndMenu(float score)
    {
        gameObject.SetActive(true);
    }
}
