using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayletter : MonoBehaviour
{
    // Start is called before the first frame update
   
    public letterobject lb;
    [SerializeField]
    public  List<string> letters;
    [SerializeField]
    public int numletters;

    [SerializeField] public SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite img;

    //get sprite render component


    public void Start()
    {

        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

        for (int i = 0; i <lb.numletters; i++)
        {
         letters[i]= lb.letters[i];

        }

        numletters = lb.numletters;

        spriteRenderer.sprite = lb.image;



    }



}
