using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Make sure to include this for UI components like Button

public class MenuStuff : MonoBehaviour
{
    public Button restartButton;

    // Set default scene to "SampleScene"
    private string nextSceneName = "SampleScene"; 

    // Start is called before the first frame update
    private void Start()
    {

        
        // Add listener to call B_LoadScene when the button is pressed
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(B_LoadScene);
        }
    }

    // Method to load the specified scene
    public void B_LoadScene()
    {
        Cursor.visible = true;
        SceneManager.LoadScene(nextSceneName);
    }

    // Method to quit the game
    public void B_QuitGame()
    {
        Application.Quit();
    }
}
