using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_1 : MonoBehaviour
{
    void Start()
    {

    }

    public void next() { 
        SceneManager.LoadScene("2-2");
    }
}
