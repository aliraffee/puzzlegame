using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayletter : MonoBehaviour
{
    // Start is called before the first frame update
    private Image img;
    public letterobject lb;
    [SerializeField]
   public  List<string> letters;
    [SerializeField]
    public int numletters;

    public void Start()
    {
        for (int i = 0; i <lb.numletters; i++)
        {
         letters[i]= lb.letters[i];

        }

        numletters = lb.numletters;
        // img.sprite=lb.image;



    }

}
