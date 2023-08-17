using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{

    public Transform player;
    Vector3 buffer = new Vector3(0f, 0f, -10f);
    public float move,smoothness = 0.25f;
    Vector3 velo = Vector3.zero;
    public int i=0,cap;
    
    // Start is called before the first frame update
    void Start()
    {
        move = 0.01f;
        cap = 100;
    }
    private void FixedUpdate()
    {
        Vector3 target = player.position + buffer;
        this.transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, smoothness);
        player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - move);
        if(i>cap)
        {
            cap += 50;
            move = 1.5f * move;
            i = 0;
        }
        i++;
    }
}


