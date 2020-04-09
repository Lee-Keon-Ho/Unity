using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource audio_soruce;
    public AudioClip appear_sound;

    // Start is called before the first frame update
    void Start()
    {
        audio_soruce = this.gameObject.AddComponent<AudioSource>();
        audio_soruce.clip = appear_sound;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    
