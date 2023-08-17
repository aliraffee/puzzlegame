using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
<<<<<<< Updated upstream
    
    [SerializeField] private GameObject Exit;

 
    void Start()
    {
       
        

    }
=======
    // Start is called before the first frame update
    [SerializeField] private GameObject Exit;

>>>>>>> Stashed changes

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("letter"))
        {
            Debug.Log("portal entered");
<<<<<<< Updated upstream
            StartCoroutine(Wait());
            other.transform.position = Exit.transform.position;
           
=======
            other.transform.position = Exit.transform.position;

>>>>>>> Stashed changes

        }

    }

<<<<<<< Updated upstream
    public IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(5);
    }



=======
>>>>>>> Stashed changes
}
