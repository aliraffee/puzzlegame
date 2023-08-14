using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;

    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

       
        Vector3 offset = new Vector3(h, v, 0);
        offset = offset.normalized * speed * Time.deltaTime;

        player.MovePosition(player.transform.position + offset);



    }
}
