using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_2 : MonoBehaviour
{
    [SerializeField]  public InputField InputText;
    [SerializeField] public static Text mytext; // 입력받은 자본금

    public void Test(Text text) {
        text.text = InputText.text;
        mytext = text;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()//편의점 선택
    {
        //편의점 클릭시 변수 추가01
        Debug.Log(mytext.text);
        SceneManager.LoadScene("2-3");
        
    }
}
