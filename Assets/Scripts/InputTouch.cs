using UnityEngine;

public class InputTouch : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;
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

        if (_rb.velocity.magnitude < 0.01f)
        {
            _rb.velocity = Vector3.zero;
        }
    }
}