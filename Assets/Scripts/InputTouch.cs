using UnityEngine;

public class InputTouch : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private Rigidbody _rb;

    [Header("Settings")]
    [SerializeField] private float _speed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _dragFactor;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 force = new Vector3(touch.deltaPosition.x, 0f, touch.deltaPosition.y);

            switch (touch.phase)
            {
                case TouchPhase.Moved:
                    _rb.AddForce(force * _speed);
                    SpeedLimit(_maxSpeed);
                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    Decelerate();
                    break;
            }
        }
    }

    private void Decelerate()
    {
        _rb.velocity *= _dragFactor;

        if (_rb.velocity.magnitude < 0.01f) _rb.velocity = Vector3.zero;
    }

    private void SpeedLimit(float speed)
    {
        if (_rb.velocity.magnitude > speed) _rb.velocity = _rb.velocity.normalized * speed;
    }
}