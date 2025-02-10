using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameCoins : MonoBehaviour
{
    private string _sceneName = "Menu";

    private void Awake()
    {
        CheckSceneName();
    }

    private void CheckSceneName()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == _sceneName) PlayerPrefs.DeleteAll();
    }
}