using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour {
    private float waitTime = 10f;
	
	void Start () {
        SlotDesign.money = 0;
	}
	
	
	void Update () {
        waitTime -= Time.deltaTime;

        if(waitTime <= 0 || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("title");
        }
	}
}
