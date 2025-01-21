using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private float _speed;

    private void Start()
    {

    }

    private void MoveBall()
    {
        if (_inputHandler.IsThereTouchOnScreen())
        {
            Vector2 currDeltaPos = _inputHandler.GetTouchDeltaPosition();
            currDeltaPos = currDeltaPos * _speed;
            Vector3 newGravityVector = new Vector3(currDeltaPos.x, Physics.gravity.y, currDeltaPos.y);
            Physics.gravity = newGravityVector;
        }
    }

    private void Update()
    {
        MoveBall();
    }
}