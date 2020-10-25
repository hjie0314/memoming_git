using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_4 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame

    public void next()//편의점 선택
    {
        //편의점 클릭시 변수 추가01
        SceneManager.LoadScene("2-5");
    }

}