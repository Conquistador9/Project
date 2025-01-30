using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void BackToMenu() => StartCoroutine(TransitionToMenu());

    private IEnumerator TransitionToMenu()
    {
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene(0);
    }
}