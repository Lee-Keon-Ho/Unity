﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wall : MonoBehaviour
{
    public float speed = -5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5.0f); // object가 생성된 후 5초 있다가 삭제
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("main_scene");
    }
}
