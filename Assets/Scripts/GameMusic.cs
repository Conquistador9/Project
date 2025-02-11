using UnityEngine;

public class GameMusic : MonoBehaviour
{
    [SerializeField] private string _musicTag;

    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag("Music");

        if(obj != null) Destroy(gameObject);
        else
        {
            gameObject.tag = _musicTag;
            DontDestroyOnLoad(gameObject);
        }
    }
}