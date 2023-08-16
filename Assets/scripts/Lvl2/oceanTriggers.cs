using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oceanTriggers : MonoBehaviour
{
    [SerializeField] private GameObject oceanDrag;
    [SerializeField] private GameObject[] triggers;
    [SerializeField] private GameObject LetterC;
    [SerializeField] private GameObject[] arrows;

    [Header("Trigger bools")]
    public bool triggered1 = false;
    public bool triggered2 = false;
    public bool triggered3 = false;
    public bool triggered4 = false;
    public bool triggered5 = false;
    public bool triggered6 = false;

    public void HintforSea()
    {
        arrows[0].SetActive(true);
        arrows[1].SetActive(true);
        arrows[2].SetActive(true);
        arrows[3].SetActive(true);
        arrows[4].SetActive(true);
        arrows[5].SetActive(true);
    }

    private void Update()
    {
        if (triggered1 == true && triggered2 == true && triggered3 == true && triggered4 == true && triggered5 == true && triggered6 == true)
        {
            LetterC.SetActive(true);
        }
    }

}
