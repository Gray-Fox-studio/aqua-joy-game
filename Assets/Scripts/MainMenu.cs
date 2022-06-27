using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame()
    {
		SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
		SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void Quit()
    {
		Application.Quit();
    }
}
