using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LevelOne() => SceneManager.LoadScene(1);
}