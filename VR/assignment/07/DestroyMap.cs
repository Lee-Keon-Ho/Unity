using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMap : MonoBehaviour
{
    private GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        head = GameObject.Find("Head");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.z < head.transform.position.z - 50.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
