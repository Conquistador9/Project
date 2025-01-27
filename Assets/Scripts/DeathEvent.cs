using UnityEngine;
using UnityEngine.Events;

public class DeathEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _event.Invoke();
        }
    }
}