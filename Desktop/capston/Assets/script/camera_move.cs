using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake() {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float scaleheight = ((float)Screen.width / Screen.height) / ((float)9 / 16);
        float scalwidth = 1f / scaleheight;
        if (scaleheight < 1) {
            rect.height = scaleheight;
            rect.y = (1f -scaleheight) / 2f;
        }
        else {
            rect.width = scalwidth;
            rect.x = (1f - scalwidth) / 2f;
        }
        camera.rect = rect;

    }
}
