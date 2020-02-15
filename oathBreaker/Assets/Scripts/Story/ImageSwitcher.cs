using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageSwitcher : MonoBehaviour
{

    public Sprite Lu; // I attched these from editor
    public Sprite Hell;
    

    public int imgNumberCount;


    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                GetComponent<Image>().sprite = Lu;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = Hell;
                imgNumberCount++;
                break;  
                
            default:
                Debug.Log("Error");
                break;
        }
    }
}

