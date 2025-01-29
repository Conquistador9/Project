using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void NextLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}