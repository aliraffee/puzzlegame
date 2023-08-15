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

    public void TopRightAntiClockwise()
    {
        topR.transform.Rotate(0f, 0f, 20f);
    }

    public void TopRightClockwise()
    {
        topR.transform.Rotate(0f, 0f, -20f);
    }

    private void Update()
    {
        
    }
}
