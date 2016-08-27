using UnityEngine;
using System.Collections;

public class Nugasu : MonoBehaviour
{

    //true 服がある
    //false 服がない
    static public bool tsirt;

    // Use this for initialization
    void Start()
    {
        tsirt = true;
    }

    
    void Update()
    {
        if (tsirt == false)
        {
            transform.Translate(10, 0, 0);
            tsirt = true;
        }

    }

}
