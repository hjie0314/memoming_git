
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class button3_11 : MonoBehaviour
{
    public GameObject answer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void score_plus()
    {
        GameObject.Find("Score").GetComponent<Score_Script>().score_p();


    }
    public void a_o()//정답 눌렀을 때
    {
        SceneManager.LoadScene("3-11-1");
        //answer = GameObject.Find("o").transform.FindChild("o").gameObject; 
        //  answer.gameObject.SetActive(true);
    }

    public void a_x()//오답 눌렀을 때
    {
        SceneManager.LoadScene("3-11-2");
        //answer = GameObject.Find("x").transform.FindChild("x").gameObject;
        //   answer.gameObject.SetActive(true);
    }

    public void next12()//x키 눌렀을 때
    {
           SceneManager.LoadScene("3-12");
    }
    public void next13()//x키 눌렀을 때
    {
          SceneManager.LoadScene("3-13");
    }
    public void next14()//x키 눌렀을 때
    {
        //  answer.gameObject.SetActive(false);
        //  Destroy(GameObject.Find("x"));
        // Destroy(GameObject.Find("o"));

        SceneManager.LoadScene("3-14");
    }
}
