using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draggingletters : MonoBehaviour
{
    // Start is called before the first frame update
  
    Vector2 buffer = Vector2.zero;
    Vector2 tomve = Vector2.zero;

    displayletter collidiingtobject, thispnke;
    private float speed=0.02f;

   
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
        if (collision.gameObject.tag!="letter")
        {
            Debug.Log("not letter");


        }else
        {

            thispnke=this.gameObject.GetComponent<displayletter>();
            collidiingtobject = collision.gameObject.GetComponent<displayletter>();
            if (thispnke.gameObject.transform.position.y > collidiingtobject.transform.position.y)
            {


                for (int i = 0; i < collidiingtobject.letters.Capacity; i++)
                {
                    thispnke.letters.Add(collidiingtobject.letters[i]);

                }
                for (int i = 0; i < thispnke.letters.Capacity; i++)
                    {
                    Debug.Log(thispnke.letters[i]);
                }

                Destroy(collision.gameObject);
            }

           
        }
    }
}


