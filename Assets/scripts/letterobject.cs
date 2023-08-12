using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenuAttribute(fileName = "letter", menuName = "Scriptableobjectletters")]
public class letterobject : ScriptableObject
{
    // Start is called before the first frame update
    public string[] letters;//the letters attatched to this 
    public int numletters;//number of letters
    public Sprite img;
}
