using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
public class moneysc : MonoBehaviour
{
    [SerializeField] public InputField InputText;
    [SerializeField] public string A;

    public void Test(Text text)
    {
        text.text = InputText.text;
        
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        A = "";
    }

    // Update is called once per frame
    void Update()
    {
        A = InputText.text;
    }
}
