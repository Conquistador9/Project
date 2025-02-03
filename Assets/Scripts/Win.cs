using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Win : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;

    [Header("Components")]
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private GameObject _win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _event.Invoke();
            _rb.constraints = RigidbodyConstraints.FreezeAll;
            StartCoroutine(WinPanel());
        }
    }

    private IEnumerator WinPanel()
    {
        yield return new WaitForSeconds(0.5f);
        _win.SetActive(true);
    }
}