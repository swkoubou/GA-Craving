using UnityEngine;
using System.Collections;

public class paa : MonoBehaviour
{
    public int count = -1;

    public void OnClick()
    {
        count = 0;
    }

    public void OnPaper(){
        count = 1;
    }

    public void OnRock()
    {
        count = 2;
    }
}
