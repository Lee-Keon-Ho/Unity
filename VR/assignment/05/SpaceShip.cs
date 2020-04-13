using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public GameObject head;
    public GameObject mainCam;
    public GameObject ship01;
    public GameObject ship02;
    public GameObject ship03;
    public GameObject ship04;
    public GameObject ship05;
    private GameObject ship;
    float cur_angle;
    float prev_angle;
    float delta_angle;
    public static int hp;
    public static float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        hp = 2;
        if (PlayerCtrl_menu.ship_name == "Ship01")
        {
            ship01.SetActive(true);
            ship = ship01;
        }
        else if(PlayerCtrl_menu.ship_name == "Ship02")
        {
            ship02.SetActive(true);
            ship = ship02;
        }
        else if(PlayerCtrl_menu.ship_name == "Ship03")
        {
            ship03.SetActive(true);
            ship = ship03;
        }
        else if (PlayerCtrl_menu.ship_name == "Ship04")
        {
            ship04.SetActive(true);
            ship = ship04;
        }else if (PlayerCtrl_menu.ship_name == "Ship05")
        {
            ship05.SetActive(true);
            ship = ship05;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hp);
        time += Time.deltaTime;
        MoveForward();
    }

    void MoveForward()
    {
        head.transform.Translate(mainCam.transform.forward * 0.3f);

        cur_angle = mainCam.transform.eulerAngles.y;
        delta_angle = cur_angle - prev_angle;
        prev_angle = cur_angle;

        if (delta_angle < 0)
        {
            ship.transform.rotation = Quaternion.Lerp(ship.transform.rotation, Quaternion.Euler(ship.transform.eulerAngles.x, ship.transform.eulerAngles.y, 45), Time.deltaTime);
        }
        else if (delta_angle > 0)
        {
            ship.transform.rotation = Quaternion.Lerp(ship.transform.rotation, Quaternion.Euler(ship.transform.eulerAngles.x, ship.transform.eulerAngles.y, -45), Time.deltaTime);
        }
        else
        {
            ship.transform.rotation = Quaternion.Lerp(ship.transform.rotation, Quaternion.Euler(ship.transform.eulerAngles.x, ship.transform.eulerAngles.y, 0), Time.deltaTime);
        }
    }
}
