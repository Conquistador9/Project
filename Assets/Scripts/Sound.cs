using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(_clip != null)
            {
                _source.PlayOneShot(_clip);
            }
        }
    }
}