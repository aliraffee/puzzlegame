using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotateLetters : MonoBehaviour
{
    [SerializeField] private GameObject triangle;

    public void AntiClockwise()
    {
        triangle.transform.Rotate(0f, 0f, 20f);
    }

    public void Clockwise()
    {
        triangle.transform.Rotate(0f, 0f, -20f);
    }
}
