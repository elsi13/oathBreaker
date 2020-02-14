using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Top_scene");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

}