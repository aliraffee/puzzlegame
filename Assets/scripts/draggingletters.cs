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
    public GameObject ball;
    int i=0;
    letterobject lb,otherlb;

   
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
        if (collision.gameObject.transform.position.y>transform.position.y)
        {
            for (int i = 0; i < otherlb.let.Capacity; i++)
            {
                lb.let.Add(otherlb.let[i]);
            }
        }


        if (collision.gameObject.name=="ll"&& this.gameObject.name=="ba")
                {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
            

                }
    }
}


