using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class oceanTriggers : MonoBehaviour
{
    [SerializeField] private GameObject oceanDrag;
    [SerializeField] private GameObject LetterC;
    [SerializeField] private GameObject[] triggers;
    [SerializeField] private GameObject[] arrows;

    [SerializeField] Button HintBtn1;
    [SerializeField] Button HintBtn2;
    [SerializeField] TMP_Text HintTxt;

    private Vector3 offSet;
    private Camera cam;

    [SerializeField] private int triggerCount;

    private void Start()
    {
        HintTxt.text = " ";
        HintBtn2.interactable = false;
    }

    public void HintforSeaTxt()
    {
        HintTxt.text = "I wonder where the ocean went... ";

        HintBtn1.interactable = false;
        HintBtn2.interactable = true;
    }

    public void HintforSea()
    {
        arrows[0].SetActive(true);
        arrows[1].SetActive(true);
        arrows[2].SetActive(true);
        arrows[3].SetActive(true);
        arrows[4].SetActive(true);
        arrows[5].SetActive(true);

        HintBtn2.interactable = false;
    }

    private void Awake()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        offSet = transform.position - GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + offSet;
    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TriggerPlate"))
        {
            triggerCount++;
            Debug.Log("Triggerd!");
        }
    }

    private void Update()
    {
        if (triggerCount == 6)
        {
            LetterC.SetActive(true);
        }
    }

}
