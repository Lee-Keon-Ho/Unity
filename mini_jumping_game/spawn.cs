using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pf_wall;
    public float interval;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            interval = Random.Range(1.0f, 2.0f);
            Instantiate(pf_wall, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval); // interval 시간 만큼 있다가 다시 실행
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
