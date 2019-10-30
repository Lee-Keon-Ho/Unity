using UnityEnglne;
using System.Collections;
using UnityEngine.Scenemanagement;

public class scene_transition : MonoBehaviour {
    private static string msg_text;
	
	//Use this for initialization
	void start () {
		
	}
	
	//Update is called once per frame
	void Update () {
		if(Input.GetMousebuttonDown(0)){
			SceneManager.LoadScene ("Scene2", LoadSceneMode.Single);
		}
	}
	
}
