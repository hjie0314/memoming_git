using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class camera_fix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResolutionFix();
    }
    private void ResolutionFix()
    {
        // 가로 세로 비율
        float targetWidthAspect = 9.0f;
        float targetHeightAspect = 16.0f;

        Camera.main.aspect = targetWidthAspect / targetHeightAspect;

        float widthRatio = (float)Screen.width / targetWidthAspect;
        float heightRatio = (float)Screen.height / targetHeightAspect;

        float heightadd = ((widthRatio / (heightRatio / 100)) - 100) / 200;
        float widthadd = ((heightRatio / (widthRatio / 100)) - 100) / 200;

        // 시작지점을 0으로 만들어준다.
        if (heightRatio > widthRatio)
            widthadd = 0.0f;
        else
            heightadd = 0.0f;

        Camera.main.rect = new Rect(
            Camera.main.rect.x + Mathf.Abs(widthadd),
            Camera.main.rect.x + Mathf.Abs(heightadd),
            Camera.main.rect.width + (widthadd * 2),
            Camera.main.rect.height + (heightadd * 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
