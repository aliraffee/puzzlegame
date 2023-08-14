using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCManager : MonoBehaviour
{
    //when player interacts with NPC -- collider/raycast -- NPC tells Player the clue
   /* [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    private int index = 0;
    [SerializeField] private float wordSpeed;
    [SerializeField] private bool playerIsClose;*/



    [SerializeField] public Queue<string> sentence;
      


    void Start()
    {
        sentence = new Queue<string>();
    }


    public void StartDialogue(Dialogue d)
    {
        Debug.Log("Convo with " + d.name);

        sentence.Clear();

        foreach(string s in d.sentences)
        {
            sentence.Enqueue(s);
        }


        DisplaySentence();
    }


    public void DisplaySentence()
    {
        if(sentence.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sent = sentence.Dequeue();
        Debug.Log(sent);
    }


    public void EndDialogue()
    {
        //
    }


    // Update is called once per frame
   /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (!dialoguePanel.activeInHierarchy)
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
            else if (dialogueText.text == dialogue[index])
            {
                NextLine();
            }

        }
        if (Input.GetKeyDown(KeyCode.Q) && dialoguePanel.activeInHierarchy)
        {
            RemoveText();
        }
    }

    public void RemoveText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            RemoveText();
        }
    }

    


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            RemoveText();
        }
    }*/
}
