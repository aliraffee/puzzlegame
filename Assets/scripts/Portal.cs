using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Exit;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("letter"))
        {
            Debug.Log("portal entered");
            other.transform.position = Exit.transform.position;


        }

    }

}
