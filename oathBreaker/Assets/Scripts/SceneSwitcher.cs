using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Top_scene");
    }

    public void GotoFirstScene()
    {
        SceneManager.LoadScene("1");
    }
	
	public void GotoHellScene()
	{
		SceneManager.LoadScene("Hell");
	}
}