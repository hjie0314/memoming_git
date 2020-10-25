using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeFirstScene()// 화면 터치 시 다음 화면으로 실행
    {
        SceneManager.LoadScene("1.Sectors");
    }
}
