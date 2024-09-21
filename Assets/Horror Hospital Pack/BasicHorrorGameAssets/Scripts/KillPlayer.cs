using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public string nextSceneName; // Name of the next scene to load
    public float delay = 0.5f; // Delay in seconds before loading the next scene
    public GameObject fadeout;

    private bool playerInsideTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cursor.visible = true;            
            playerInsideTrigger = true;
            fadeout.SetActive(true);
            Invoke("LoadNextScene", delay);
        }
    }


    private void LoadNextScene()
    {
        if (playerInsideTrigger)
        {
            Cursor.visible = true;
            // Load the next scene by name
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
