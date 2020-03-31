using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeVideo : MonoBehaviour
{
    public VideoClip clip01;
    public VideoClip clip02;
    bool isClip02;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change02()
    {
        if (!isClip02)
        {
            gameObject.GetComponent<VideoPlayer>().clip = clip02;
            isClip02 = true;
        }
    }
}
