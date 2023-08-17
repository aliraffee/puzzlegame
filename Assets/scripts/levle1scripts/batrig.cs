using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batrig : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject celldoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.rotation.z<=-0.4f && collision.transform.rotation.z>=-0.9)
        {
            celldoor.SetActive(false);
        }
        Debug.Log(collision.transform.rotation.z);
        if( collision.gameObject.transform.childCount != 0 )
        {
            celldoor.SetActive(false);
        }
        
    }
}
