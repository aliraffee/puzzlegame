using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubbishCollection : MonoBehaviour
{
    private Vector3 offSet;
    private Camera cam;

    [SerializeField] private int rubbishCount;
    [SerializeField] private GameObject inLetters;

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
        if (collision.gameObject.CompareTag("Rubbish"))
        {
            Destroy(collision.gameObject);
            rubbishCount++;
            Debug.Log("Rubbish destroyed!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Boarder")
        {
            Debug.Log("This is a boarder");
        }
    }

    private void Update()
    {
        if (rubbishCount == 5)
        {
            inLetters.SetActive(true);
        }
    }
}
