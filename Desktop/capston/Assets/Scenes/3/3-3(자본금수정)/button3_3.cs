using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class button3_3 : MonoBehaviour
{
    public Text txt;

    void Start()
    {
        moneysc moneysc = GameObject.Find("money").GetComponent<moneysc>();

        txt.text = "자본금\n" + moneysc.A + "\n에 따른\n 예상 카페 규모";
    }


    public void capital()//자본금 수정
    {
        Destroy(GameObject.Find("money"));
        SceneManager.LoadScene("3-2");
    }
    public void next()//다음 단계
    {
        //카페 클릭시 변수 추가
        Destroy(GameObject.Find("money"));
        SceneManager.LoadScene("3-4");
    }
}
