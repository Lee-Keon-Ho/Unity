using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    public GameObject explosion;
    public AudioClip explosionSound;
    private float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Crash());
    }
    private void OnTriggerExit(Collider other)
    {
        if (time > 0.5f)
        {
            SpaceShip.hp--;
            Debug.Log(SpaceShip.hp);
            time = 0.0f;
        }
        if (SpaceShip.hp == 0)
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
            SpaceShip.hp = 2;
        }
    }

    IEnumerator Crash()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(explosionSound);
        explosion.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
}
