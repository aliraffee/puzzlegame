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
    public GameObject ball,ballin,nill;
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
            ball.SetActive(true);
            ball.transform.position = this.gameObject.transform.position;
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
           

        }

        if (collision.gameObject.name == "ll" && this.gameObject.name == "in")
        {
            nill.SetActive(true);
            nill.transform.position = this.gameObject.transform.position;
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);


        }
        if((collision.gameObject.name == "ball" && this.gameObject.name == "in")||(collision.gameObject.name == "nill" && this.gameObject.name == "ba"))
        {
            ballin.SetActive(true);
            ballin.transform.position = this.gameObject.transform.position;
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);


        }

        //lvl3

        //confused
        if (collision.gameObject.name == "empty" && this.gameObject.name == "us")
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

        //Level 2
        if (collision.gameObject.name == "ck" && this.gameObject.name == "ro")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }

        if (collision.gameObject.name == "in" && this.gameObject.name == "ck")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }

        //rock become rockin
        if (collision.gameObject.name == "in" && this.gameObject.name == "Rock")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);

        }

    }
}


