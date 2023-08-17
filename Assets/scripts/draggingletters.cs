using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draggingletters : MonoBehaviour
{
    // Start is called before the first frame update
    public letterobject obj;
    Vector2 buffer = Vector2.zero;
    Vector2 tomve = Vector2.zero;
    private float speed=0.02f;
    public GameObject ball;
    public GameObject ed;
    public void FixedUpdate()
    {
        // Debug.Log(obj.numletters);

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


        if (collision.gameObject.name == "ll" && this.gameObject.name == "ba")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }

        //lvl3

        //confused
        if(collision.gameObject.name == "empty" && this.gameObject.name == "us")
        {
            ed.SetActive(true);
        }
        if (collision.gameObject.name == "empty" && this.gameObject.name == "confus")
        {
            ed.SetActive(true);
        }

        if (collision.gameObject.name == "nf" && this.gameObject.name == "co")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }
        if (collision.gameObject.name == "us" && this.gameObject.name == "conf")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }
        if (collision.gameObject.name == "ed" && this.gameObject.name == "confus")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }

        //used
        if (collision.gameObject.name == "ed" && this.gameObject.name == "us")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }
        if (collision.gameObject.name == "us" && this.gameObject.name == "us")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }
        
    }
}


