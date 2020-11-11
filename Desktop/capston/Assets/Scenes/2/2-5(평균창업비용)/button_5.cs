using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_5 : MonoBehaviour
{
    void Start()
    {

    }

    public void next()//뒤로가기 버튼?
    {
        SceneManager.LoadScene("2-6");
    }

}