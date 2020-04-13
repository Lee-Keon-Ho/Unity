using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change01()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void Change_Ship()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    public void Change02()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
