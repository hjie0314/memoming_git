using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_3 : MonoBehaviour
{
    public Text txt;

    void Start()
    {
        moneysc moneysc = GameObject.Find("money").GetComponent<moneysc>();
        
        txt.text = "자본금" + moneysc.A + "에 따른 예상 편의점 규모";
    }


    public void capital()//자본금 수정
    {
        Destroy(GameObject.Find("money"));
        SceneManager.LoadScene("2-2.capital");
    }
    public void next()//다음 단계
    {
        //카페 클릭시 변수 추가
        Destroy(GameObject.Find("money"));
        SceneManager.LoadScene("2-4");
    }
}
