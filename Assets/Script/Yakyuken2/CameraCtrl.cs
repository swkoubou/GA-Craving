using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject secondCamera;
    public GameObject thirdCamera;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            mainCamera.GetComponent<Camera>().enabled = true;
            secondCamera.GetComponent<Camera>().enabled = false;
            thirdCamera.GetComponent<Camera>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            mainCamera.GetComponent<Camera>().enabled = false;
            secondCamera.GetComponent<Camera>().enabled = true;
            thirdCamera.GetComponent<Camera>().enabled = false;

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mainCamera.GetComponent<Camera>().enabled = false;
            secondCamera.GetComponent<Camera>().enabled = false;
            thirdCamera.GetComponent<Camera>().enabled = true;
        }
    }
}
