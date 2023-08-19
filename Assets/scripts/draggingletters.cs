
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draggingletters : MonoBehaviour
{
    // Start is called before the first frame update
    public letterobject obj;
    Vector2 buffer = Vector2.zero;
    Vector2 tomve = Vector2.zero;
    private float speed = 0.02f;
    public GameObject ball,ballin,nill;
    public GameObject ed;

    [SerializeField] GameObject rotateLett;
    [SerializeField] GameObject rubbishCollec;
    [SerializeField] GameObject OceanTrig;

    [SerializeField] GameObject NextLevel;


    [SerializeField] GameObject confused;
    [SerializeField] GameObject finishedTrigger;
    [SerializeField] GameObject finishedTriggertext;


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
            ball.transform.position = transform.position;
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
           

        }
        if (collision.gameObject.name == "in" && this.gameObject.name == "ll")
        {
            nill.SetActive(true);
            nill.transform.position = transform.position;
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
         

        }
        if ((collision.gameObject.name == "ball" && this.gameObject.name == "in")|| (collision.gameObject.name == "nill" && this.gameObject.name == "ba"))
        {
            ballin.SetActive(true);
            ballin.transform.position = transform.position;
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
           

        }
       
      

        //lvl3

        //confused
        if (collision.gameObject.name == "empty" && this.gameObject.name == "us")
        {
            ed.SetActive(true);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "empty" && this.gameObject.name == "confus")
        {
            ed.SetActive(true);
            collision.gameObject.SetActive(false);
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
            finishedTrigger.SetActive(true);
            finishedTriggertext.SetActive(true);
            ball.SetActive(true);

        }

        //used
        if (collision.gameObject.name == "ed" && this.gameObject.name == "us")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
            finishedTrigger.SetActive(true);
            finishedTriggertext.SetActive(true);

        }

        
        if (collision.gameObject.name == "conf" && this.gameObject.name == "used")
        {
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            confused.SetActive(true);
            finishedTrigger.SetActive(true);
            finishedTriggertext.SetActive(true);

        }
        

        //Level 2
        if (collision.gameObject.name == "ck" && this.gameObject.name == "ro")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
            rotateLett.SetActive(false);
            OceanTrig.SetActive(false);
        }

        if (collision.gameObject.name == "in" && this.gameObject.name == "ck")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
            rubbishCollec.SetActive(false);
        }

        //rock become rockin
        if (collision.gameObject.name == "in" && this.gameObject.name == "Rock")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
            NextLevel.SetActive(true);
        }

        //Tutorial level 2
        if (collision.gameObject.name == "st" && this.gameObject.name == "op")
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
             Debug.Log("yes");
            collision.gameObject.SetActive(false);
            ball.SetActive(true);
            //ballin.transform.position = transform.position;
           
            nill.SetActive(false);

        }

    }
}


