using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    
    [SerializeField] private GameObject Exit;

 
    void Start()
    {
       
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("letter"))
        {
            Debug.Log("portal entered");
            StartCoroutine(Wait());
            other.transform.position = Exit.transform.position;
           

        }

    }

    public IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(5);
    }



}
