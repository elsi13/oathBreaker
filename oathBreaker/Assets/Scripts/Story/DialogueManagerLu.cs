using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManagerLu: MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
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
        image_animator.SetInteger("lu_mood", 0);
        nameText.text = dialogue.name;
        

        sentences.Clear();



        switch (Global.Lu_story)
        {
            case 0:

                start = 0;
                end = 10;
               

                break;
            case 1:
                // do something


                if (Global.Daniele_story == 0)
                {
                    start = 9;
                    end = 10;
                }
                if (Global.Yash_story == 0)
                {
                    start = 9;
                    end = 10;
                }
                else
                {
                    start = 9;
                    end = 10;

                    if (Global.been_to_hell_and_back == true)
                    {
                        if (Global.Yash_story == 1)
                        {
                            start = 11;
                            end = 23;
                        }
                        else
                        { 
                            start = 23;
                            end = 32;

                        }
                        
                    }


                }


                break;
            case 2:
                break;
            default:
                break;
        }
        for (int i = start; i < end; i++)
        {
            sentences.Enqueue(dialogue.sentences.GetValue(i).ToString());
        }

        DisplayNextSentence();

    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            Global.Lu_story = 1;
            EndDialogue();
            next_animator.SetBool("Next", true);
            return;
        }

        string sentence = sentences.Dequeue();


        if (sentences.Count == 5)
        {
            image_animator.SetInteger("lu_mood", 3);
            Debug.Log("Anything");
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
            return;
        }

        if (sentences.Count == 1)
        {
            image_animator.SetInteger("lu_mood", 2);

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
