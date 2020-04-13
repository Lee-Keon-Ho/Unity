using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public Image CursorGaugeImage;
    private Vector3 ScreenCenter;
    private float GaugeTimer;

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

        if (Physics.Raycast(ray, out hit, 1000.0f) && (hit.transform.gameObject.tag == "start" || hit.transform.gameObject.tag == "reStart")) 
        {
            
            GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
            if (GaugeTimer >= 1.0f)
            {
                if (hit.transform.gameObject.tag == "start")
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                }
                if (hit.transform.gameObject.tag == "reStart")
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                }
                GaugeTimer = 0.0f;
            }
        }
        else
        {
            GaugeTimer = 0.0f;
        }
    }
}
