using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_1 : MonoBehaviour
{
    void Start()
    {

    }

    public void Convenience()//편의점 선택
    {
        //편의점 클릭시 변수 추가01
        SceneManager.LoadScene("2-2.capital");
    }
    public void cafe()//카페 선택02
    {
        //카페 클릭시 변수 추가
        SceneManager.LoadScene("3-2.capital");
    }
}
