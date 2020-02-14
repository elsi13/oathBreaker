using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySwitcher : MonoBehaviour
{



    public int snc;
    public void ChangeStory() // make sure to attach this to event trigger
    {

        switch (snc)
        {

            case 0:
                SceneManager.LoadScene("2");
                snc++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                SceneManager.LoadScene("1");
                snc++;
                break;

            default:
                Debug.Log("Error");
                break;
        }
    }
}
  
