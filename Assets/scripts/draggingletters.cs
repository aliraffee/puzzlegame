using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draggingletters : MonoBehaviour
{
    // Start is called before the first frame update
  
    Vector2 buffer = Vector2.zero;
    Vector2 tomve = Vector2.zero;
    private float speed=0.02f;

   
    private void OnMouseDown()
    {
        buffer = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }
    private void OnMouseDrag()
    {
        tomve = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - buffer;
        transform.position = Vector2.MoveTowards(transform.position, tomve, speed);
    }
}


