using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_0 : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    Magnifying_Panel = GameObject.Find("c").transform.FindChild("Magnifying_Panel").gameObject; 테그로 찾기
    }

    public void Convenience()//편의점 선택
    {
        //편의점 클릭시 변수 추가01
        SceneManager.LoadScene("2-1.Convenience");
    }
    public void cafe()//카페 선택02
    {
        //카페 클릭시 변수 추가
        SceneManager.LoadScene("3-1.cafe");
    }
}
