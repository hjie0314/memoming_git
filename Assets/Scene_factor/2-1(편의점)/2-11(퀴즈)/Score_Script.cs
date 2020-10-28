using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Script : MonoBehaviour
{
    
    public int score = 0;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void score_p()
    {
        score++;
    }
    void Awake()
    {
       DontDestroyOnLoad(this);
  }
}
