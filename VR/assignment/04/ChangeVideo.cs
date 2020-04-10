using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeVideo : MonoBehaviour
{
    public VideoClip clip01;
    public VideoClip clip02;
    bool isClip01;
    bool isClip02;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change01()
    {
        if (isClip01)
        {
            gameObject.GetComponent<VideoPlayer>().clip = clip01;
            gameObject.GetComponent<VideoPlayer>().Play();
            isClip01 = false;
        }
        else
        {
            gameObject.GetComponent<VideoPlayer>().Pause();
            isClip01 = true;
        }
        isClip02 = true;
    }
    public void Change02()
    {
        if (isClip02)
        {
            gameObject.GetComponent<VideoPlayer>().clip = clip02;
            gameObject.GetComponent<VideoPlayer>().Play();
            isClip02 = false;
        }
        else
        {
            gameObject.GetComponent<VideoPlayer>().Pause();
            isClip02 = true;
        }
        isClip01 = true;
    }
}
