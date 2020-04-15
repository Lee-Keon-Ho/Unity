using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    public GameObject mainCam;
    private float moveSpeed = 6.0f;
    private float runSpeed = 10.0f;
    private float positionX = 0.0f;
    private float accel = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    // Update is called once per frame
    void Update()
    {
        positionX = this.transform.position.x - mainCam.transform.rotation.z * moveSpeed / 90.0f;

        this.transform.position = new Vector3(positionX, this.transform.position.y, this.transform.position.z);

        Run();
    }

    void Run()
    {
        this.transform.position += this.transform.forward * runSpeed * Time.deltaTime;
    }

    IEnumerator SpeedUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.0f);

            runSpeed += accel;
        }
    }
}
