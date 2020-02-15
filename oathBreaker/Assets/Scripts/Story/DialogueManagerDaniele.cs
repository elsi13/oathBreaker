using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManagerDaniele: MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private int count = 0;
    private int start, end;


    public Animator dialogue_animator;
    public Animator next_animator;
    public Animator panel_animator;
    public Animator image_animator;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    public void StartDialogue (Dialogue dialogue)
    {

        dialogue_animator.SetBool("IsOpen", true);
        next_animator.SetBool("Next", false);
        panel_animator.SetInteger("image", 0);
        image_animator.SetInteger("dan_mood", 0);
        nameText.text = dialogue.name;
        

        sentences.Clear();

        /*foreach (string sentence in dialogue.sentences)
        {
            Debug.Log(dialogue.sentences.GetValue(1));

            sentences.Enqueue(sentence);
        }*/
        switch (Global.Daniele_story){
            case 0:

                start = 0;
                end = 9;
                Global.Daniele_story = Global.Daniele_story + 1;

                break;
            case 1:
                // do something
                if (Global.Lu_story == 0)
                {
                    start = 8;
                    end = 9;
                }
                if (Global.Yash_story == 0)
                {
                    start = 8;
                    end = 9;
                }


                break;
            case 2:
                break;
            default:
                break;
        }
        for (int i=start; i<end; i++)
        {
            sentences.Enqueue(dialogue.sentences.GetValue(i).ToString());
        }

        

        DisplayNextSentence();
        count = sentences.Count;

    }
    public void DisplayNextSentence()
    {

        if (sentences.Count == 0) 
        {
            EndDialogue();
            next_animator.SetBool("Next", true);
            return;
        }

        string sentence = sentences.Dequeue();

        if (count-sentences.Count == 3)
        {
            image_animator.SetInteger("dan_mood", 1);


            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
            return;
        }

        


        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
            


    } 
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
        {
        dialogue_animator.SetBool("IsOpen", false);
        

        }
}
