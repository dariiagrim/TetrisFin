using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControls : MonoBehaviour
{
    public string theme = "GeometryScene";
    void Start() 
    { 
        if (PlayerPrefs.HasKey("highScore")) 
            GameObject.Find("RecordObj").GetComponentInChildren<Text>().text = "Current record: " + PlayerPrefs.GetInt("highScore");
    }
    public void PlayGame()
    {
        Debug.Log(theme);
        SceneManager.LoadScene(theme);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeTheme(Button button)
    {
       theme = button.name + "Scene"; 
    }

}
