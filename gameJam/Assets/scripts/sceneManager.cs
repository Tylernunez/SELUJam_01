using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {


	public void LoadScene(string destination)
	{
			SceneManager.LoadScene(destination);
	}

	public void setMainMenu()
	{
        StartCoroutine(AddDelayMainMenu());
	}

	public void setExitGame()
	{
		Application.Quit();
	}
	public void setLevelSelect()
	{
        StartCoroutine(AddDelayLevelSelect());
	}
	public void setLeveltest()
	{
		LoadScene("mapMoveTest");
	}
    public void setLevel2()
    {
        LoadScene("level2");
    }
    public void setHelp()
    {
        StartCoroutine(AddDelayHelp());
    }
    public void setRestartLevel()
    {
        LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator AddDelayLevelSelect()
    {
        // Do something
        yield return new WaitForSeconds(.3f);  // Wait three seconds
        LoadScene("levelselect");                                      // Do something else
    }
    IEnumerator AddDelayHelp()
    {
        // Do something
        yield return new WaitForSeconds(.3f);  // Wait three seconds
        LoadScene("help");                                      // Do something else
    }
    IEnumerator AddDelayMainMenu()
    {
        // Do something
        yield return new WaitForSeconds(.3f);  // Wait three seconds
        LoadScene("mainmenu");                                      // Do something else
    }
}