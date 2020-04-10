using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayClick : MonoBehaviour
{
    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;

        if(Physics.Raycast(transform.position,forward,out hit))
        {
            Timer += 1.0f / 2.0f * Time.deltaTime;

            if (Input.GetMouseButtonDown(0))
            {
                 hit.transform.GetComponent<Button>().onClick.Invoke();
            }

            if (Timer >= 1.0f)
            {
                hit.transform.GetComponent<Button>().onClick.Invoke();
                Timer = 0.0f;
            }
        }
        else
        {
            Timer = 0.0f;
        }
    }
}
