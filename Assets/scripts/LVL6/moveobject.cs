using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    [SerializeField] private float pushPower = 2f;
    private Rigidbody2D box;
    

    private void Start()
    {
        box = this.GetComponent<Rigidbody2D>();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "letter")
        {
            if (box != null)
            {
                box.AddForce(collision.transform.position * pushPower);
            }
        }

        if(collision.transform.tag == "crate")
        {
            Debug.Log("block entered");
            collision.gameObject.SetActive(false);
        }
    }
}
