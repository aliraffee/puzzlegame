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
 
        if (collidedObject != null)
        {
            Vector3 offset = new Vector3(1, 0, 0); // replace with your desired offset vector
            this.transform.position = collidedObject.transform.position + offset;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "letter")
        {
            collidedObject = collision.transform.gameObject;
        }
    }
}
