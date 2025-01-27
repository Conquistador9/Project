using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioClip _coinClip;
    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(_coinClip != null)
            {
                _source.PlayOneShot(_coinClip);
            }
        }
    }
}