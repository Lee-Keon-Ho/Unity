using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadMove : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject text;
    private float reStart = 0.0f;
    private float moveSpeed = 15.0f;
    private float runSpeed = 10.0f;
    private float maxSpeed = 13.0f;
    private float positionX = 0.0f;
    private float accel = 0.5f;
    private bool gameOver = false;
    private float Timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) // reStart 확인
        {
            reStart += Time.deltaTime;
            if (reStart >= 3.0f) // 3초후 재시작
            {
                SceneManager.LoadScene(0, LoadSceneMode.Single);
            }
        }

        if (!gameOver)
        {
            Timer += Time.deltaTime;
        }

        if (this.transform.position.x > 4.0f) // x축 이동 범위 제한
        {
            this.transform.position = new Vector3(4.0f, this.transform.position.y, this.transform.position.z);
        }
        else if (this.transform.position.x < -4.0f) // x축 이동 범위 제한
        {
            this.transform.position = new Vector3(-4.0f, this.transform.position.y, this.transform.position.z);
        }

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
            if (runSpeed != 0)
            {
                if (runSpeed < maxSpeed)
                {
                    runSpeed += accel;
                }
            }
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Obstacle")
        {
            text.SetActive(true);
            runSpeed = 0.0f;
            gameOver = true;
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(220, Screen.height - 350, 128, 32), Timer.ToString());
    }
}
