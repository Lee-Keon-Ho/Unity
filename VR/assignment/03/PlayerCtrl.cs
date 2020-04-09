using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    public Image CursorGaugeImage;
    private Vector3 ScreenCenter;
    private float GaugeTimer;
    private bool isTriggered = false;
    public Text TextUI;
    public AudioSource audio_source;
    private AudioClip appear_sound;
    private bool GameStart = true;
    private float soundTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
        RaycastHit hit;
        CursorGaugeImage.fillAmount = GaugeTimer;


        if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject.tag != "Quad")
        {
            
            if (GameStart && Input.GetMouseButtonDown(0) && hit.transform.gameObject.tag == "Cube") 
            {
                SceneManager.LoadScene(0, LoadSceneMode.Single);
                GameStart = false;
            }
            

            if (soundTime <= 1.0f || isTriggered)
            {
                audio_source.clip = hit.collider.GetComponent<Sound>().appear_sound;
                audio_source.loop = true;
                audio_source.Play();
            }

            soundTime += 1.0f;
            GaugeTimer += 1.0f / 3.0f * Time.deltaTime;
            //Debug.Log(hit.collider.gameObject.name);

            if (GaugeTimer >= 1.0f || isTriggered) 
            {
                TextUI.text = hit.collider.GetComponent<ObjectText>().text;
                GaugeTimer = 0.0f;
                isTriggered = false;
            }
        }
        else
        {
            audio_source.Stop();
            soundTime = 0.0f;
            GaugeTimer = 0.0f;
        }
    }
}
