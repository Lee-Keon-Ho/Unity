using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result : MonoBehaviour
{
    public GameObject ship01;
    public GameObject ship02;
    public GameObject ship03;
    public GameObject ship04;
    public GameObject ship05;
    public Text text;
    private GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerCtrl_menu.ship_name == "Ship01")
        {
            ship01.SetActive(true);
        }
        else if (PlayerCtrl_menu.ship_name == "Ship02")
        {
            ship02.SetActive(true);
        }
        else if (PlayerCtrl_menu.ship_name == "Ship03")
        {
            ship03.SetActive(true);
        }
        else if (PlayerCtrl_menu.ship_name == "Ship04")
        {
            ship04.SetActive(true);
        }
        else if (PlayerCtrl_menu.ship_name == "Ship05")
        {
            ship05.SetActive(true);
        }
        text.text = SpaceShip.time.ToString();
        SpaceShip.time = 0.0f;
        SpaceShip.hp = 2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
