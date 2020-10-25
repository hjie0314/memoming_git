using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_15 : MonoBehaviour
{
    int S = 0;
    // Start is called before the first frame update
    void Start()
    {
      S = GameObject.Find("Score").GetComponent<Score_Script>().score;
        if (S == 3) { GameObject.Find("Scoreimage").transform.Find("Image_1").gameObject.SetActive(true); }
        else if (S == 2) { GameObject.Find("Scoreimage").transform.Find("Image_2").gameObject.SetActive(true); }
        else if (S == 1) { GameObject.Find("Scoreimage").transform.Find("Image_3").gameObject.SetActive(true); }
        else { GameObject.Find("Scoreimage").transform.Find("Image_3").gameObject.SetActive(true); }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void FirstScene()
    {
        SceneManager.LoadScene("0.FirstScene");
    }
}
