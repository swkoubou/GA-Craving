using UnityEngine;
using System.Collections;

public class Nugasu_Tshirt : MonoBehaviour
{
    SpriteRenderer SR;

    static public float tshirt_a;  //服のplha値を保持

    void Start()
    {
        this.SR = GetComponent<SpriteRenderer>(); //透明にするのに必要な奴
        tshirt_a = 1;

    }

    void Tshirt_alpha(float alpha)
    {
        this.SR.color = new Color(1, 1, 1, alpha);
    }

    void Update()
    {
        Tshirt_alpha(tshirt_a);
    }
 
}