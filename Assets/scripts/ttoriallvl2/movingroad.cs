using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingroad : MonoBehaviour
{
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (this.transform.position.y<-2.6)
        {
            this.transform.position = new Vector3(transform.position.x,2.6f, transform.position.z);
        }
        this.transform.position = new Vector3(transform.position.x, transform.position.y-0.0f, transform.position.z);

    }
}
