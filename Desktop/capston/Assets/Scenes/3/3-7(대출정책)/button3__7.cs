
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class button3__7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void next1()//정책 목록
    {
        SceneManager.LoadScene("3-7-1(2)");
    }
    public void next2()//정책 목록
    {
        SceneManager.LoadScene("3-7-2(2)");
    }

    public void pre()//정책 목록
    {
        SceneManager.LoadScene("3-7");
    }
}
