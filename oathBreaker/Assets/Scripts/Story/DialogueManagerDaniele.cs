using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManagerDaniele: MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private int count = 0;


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

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
        count = sentences.Count;

    }
    public void DisplayNextSentence()
    {
        if (count-sentences.Count == 8) 
        {
            EndDialogue();
            next_animator.SetBool("Next", true);
            return;
        }

        string sentence = sentences.Dequeue();

        if (count-sentences.Count == 3)
        {
            image_animator.SetInteger("dan_mood", 1);

            Debug.Log(Global.Yash_story);
            Global.Yash_story = 1;
            Debug.Log(Global.Yash_story);

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
