using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManagerLu: MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;


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

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();

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
