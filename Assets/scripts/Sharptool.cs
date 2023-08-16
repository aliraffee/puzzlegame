using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharptool : MonoBehaviour
{
    private GameObject collidedObject;
    // Start is called before the first frame update
    void Start()
    {
        collidedObject = null;

    }

    // Update is called once per frame
    void Update()
    {
 
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "letter")
        {
            GetComponent<draggingletters>().enabled = true;
        }
    }
}
