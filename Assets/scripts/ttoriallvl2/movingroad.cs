using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingroad : MonoBehaviour
{
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (this.transform.position.y<-5)
        {
            this.transform.position = new Vector3(transform.position.x,5.53f, transform.position.z);
        }
        this.transform.position = new Vector3(transform.position.x, transform.position.y-0.01f, transform.position.z);

    }
}
