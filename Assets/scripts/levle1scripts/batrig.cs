using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batrig : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject celldoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.rotation.x<=-80|| collision.transform.rotation.x>=-100|| collision.gameObject.transform.childCount != 0) 
        {
            celldoor.SetActive(false);
        }
       
    }
}
