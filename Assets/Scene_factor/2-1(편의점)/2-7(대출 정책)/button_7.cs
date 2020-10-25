using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bt1()//햇살론
    {
        SceneManager.LoadScene("2-7-1");
    }
    public void bt2()//사잇돌
    {
        SceneManager.LoadScene("2-7-2");
    }
    public void bt3()//소상공인 정책자금 지원제도
    {
        SceneManager.LoadScene("2-7-3");
    }
    public void bt4()//미소금융사업
    {
        SceneManager.LoadScene("2-7-4");
    }
    public void bt5()//사회연대은행
    {
        SceneManager.LoadScene("2-7-5");
    }

    public void next()//다음 내용
    {
        SceneManager.LoadScene("2-8");
    }
}
