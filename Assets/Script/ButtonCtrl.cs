using UnityEngine;
using System.Collections;

public class ButtonCtrl : MonoBehaviour
{
    public bool isStartButton;
    public bool isLeftButton;
    public bool isCenterButton;
    public bool isRightButton;


    void Start()
    {
        isStartButton = false;
        isLeftButton = false;
        isCenterButton = false;
        isRightButton = false;
    }


    void Update()
    {

    }


    public void OnStartButton()
    {
        if (!isStartButton)
        {
            isStartButton = true;
        }
    }

    public void OnLeftButton()
    {
        if (isStartButton)
        {
            isLeftButton = true;
        }
    }

    public void OnCenterButton()
    {
        if (isStartButton)
        {
            isCenterButton = true;
        }
    }

    public void OnRightButton()
    {
        if (isStartButton)
        {
            isRightButton = true;
        }
    }

    public bool IsAllButtonOn()
    {
        return isLeftButton && isCenterButton && isRightButton;
    }

    public void AllButtonFalse()
    {
        isStartButton = false;
        isLeftButton = false;
        isCenterButton = false;
        isRightButton = false;
    }
}