using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private Transform _ball;

    [Header("Position")]
    [SerializeField] private float _positionZ;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _ball.position;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = _ball.position + _offset;
        newPosition.z = _positionZ;
        transform.position = newPosition;
    }
}