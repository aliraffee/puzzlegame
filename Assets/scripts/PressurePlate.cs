using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject door;
    
    [SerializeField] private Sprite sprite_open;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("letter"))
        {
            //remove door1
            Debug.Log("pressure plate activated");

            door.GetComponent<SpriteRenderer>().sprite = sprite_open;
            door.GetComponent<Collider2D>().enabled = false;
        }
    }
}