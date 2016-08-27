using UnityEngine;
using System.Collections;

public class NugasuButton : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    { // MUST public
        Nugasu.tsirt = false;
        Debug.Log("clicked");
    }
}