using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Tutorial_1 : MonoBehaviour
{
    Vector2 buffer = Vector2.zero;
    Vector2 tomve = Vector2.zero;
    private float speed = 0.02f;
    public GameObject ball;

    public GameObject NextScenePanel;

    [SerializeField] GameObject ri;
    [SerializeField] GameObject al;

    [SerializeField] TMP_Text StartingTxt;
    [SerializeField] TMP_Text DragTuandToTxt;
    [SerializeField] GameObject DragTuandToTxtGO;

    [SerializeField] TMP_Text updateDragTuandToText;
    [SerializeField] GameObject updateDragTuandToTextGO;

    [SerializeField] TMP_Text updateDragRiandAlText;
    [SerializeField] GameObject updateDragRiandAlTextGO;

    [SerializeField] TMP_Text updateDragTutoandRialText;
    [SerializeField] GameObject updateDragTutoandRialTextGO;

    void Start()
    {
        StartingTxt.text = "Hello and welcome to the tutorial!";
        DragTuandToTxt.text = "Start by dragging tu and to together";
        updateDragTuandToText.text = "Well Done! And now try the other letters";
        updateDragRiandAlText.text = "Well Done! One more time";
        updateDragTutoandRialText.text = "Easy right? Time to go onto the next level";

        Invoke("TutOver", 25f);
    }

    private void OnMouseDown()
    {
        buffer = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }
    private void OnMouseDrag()
    {
        tomve = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - buffer;
        transform.position = Vector2.MoveTowards(transform.position, tomve, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Tutorial Level 1
        //Tuto
        if (collision.gameObject.name == "to" && this.gameObject.name == "tu")
        {
            //DragTuandToTxt.text = "Well Done! And now try the other letters";
            DragTuandToTxtGO.SetActive(false);
            updateDragTuandToTextGO.SetActive(true);
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
            ri.SetActive(true);
            al.SetActive(true);
        }

        //rial
        if (collision.gameObject.name == "al" && this.gameObject.name == "ri")
        {
            //DragTuandToTxt.text = "Well Done! One more time";
            updateDragTuandToTextGO.SetActive(false);
            updateDragRiandAlTextGO.SetActive(true);
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
        }

        //Tuto and rial become Tutorial
        if (collision.gameObject.name == "Rial" && this.gameObject.name == "Tuto")
        {
            //DragTuandToTxt.text = "Easy right? Time to go onto the next level";
            updateDragRiandAlTextGO.SetActive(false);
            updateDragTutoandRialTextGO.SetActive(true);
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
        }
    }

    void TutOver()
    {
            NextScenePanel.SetActive(true);
    }
}
