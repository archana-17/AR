﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CupboardScript : MonoBehaviour
{
    public void PlayGame () 
    {
        Debug.Log("Reached sofa scene");
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 4);
    }
    
}
