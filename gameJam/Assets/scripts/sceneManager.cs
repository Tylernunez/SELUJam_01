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

		LoadScene("mainmenu");
	}

	public void setExitGame()
	{
		Application.Quit();
	}
	public void setLevelSelect()
	{

		LoadScene("levelselect");
	}
	public void setLeveltest()
	{

		LoadScene("mapMoveTest");
	}
    public void setHelp()
    {

        LoadScene("help");
    }
    public void setRestartLevel()
    {
        LoadScene(SceneManager.GetActiveScene().name);
    }
}