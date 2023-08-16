using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotateLetters : MonoBehaviour
{
    [SerializeField] private GameObject topR;
    [SerializeField] private GameObject topL;
    [SerializeField] private GameObject bottomR;
    [SerializeField] private GameObject bottomL;

    [Header("Btn Click number")]
    [SerializeField] int TopRButtonClick = 0;
    [SerializeField] int TopLButtonClick = 0;
    [SerializeField] int BottomRButtonClick = 0;
    [SerializeField] int BottomLButtonClick = 0;

    [Header("Btns")]
    [SerializeField] Button TopRBtn;
    [SerializeField] Button TopLBtn;
    [SerializeField] Button BottomRBtn;
    [SerializeField] Button BottomLBtn;

    [SerializeField] GameObject rokLetters;

    public void TopRightClockwise()
    {
        topR.transform.Rotate(0f, 0f, -20f);
        TopRButtonClick++;
        TopRBtnDisabled();
    }

    public void TopLeftClockwise()
    {
        topL.transform.Rotate(0f, 0f, -20f);
        TopLButtonClick++;
        TopLBtnDisabled();
    }

    public void BottomRightClockwise()
    {
        bottomR.transform.Rotate(0f, 0f, -20f);
        BottomRButtonClick++;
        BottomRBtnDisabled();
    }

    public void BottomLeftClockwise()
    {
        bottomL.transform.Rotate(0f, 0f, -20f);
        BottomLButtonClick++;
        BottomLBtnDisabled();
    }

    public void TopRBtnDisabled()
    {
        if (TopRButtonClick == 4)
        {
            TopRBtn.interactable = false;
        }
    }

    public void TopLBtnDisabled()
    {
        if (TopLButtonClick == 17)
        {
            TopLBtn.interactable = false;
        }
    }

    public void BottomRBtnDisabled()
    {
        if (BottomRButtonClick == 14)
        {
            BottomRBtn.interactable = false;
        }
    }

    public void BottomLBtnDisabled()
    {
        if (BottomLButtonClick == 16)
        {
            BottomLBtn.interactable = false;
        }
    }

    private void Update()
    {
        if(TopRButtonClick == 4 && TopLButtonClick == 17 && BottomRButtonClick == 14 && BottomLButtonClick == 16)
        {
            rokLetters.SetActive(true);
        }
    }
}
