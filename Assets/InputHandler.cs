using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 GetTouchDeltaPosition()
    {
        //если есть касание
        if(Input.touchCount > 0)
        {
            return Input.GetTouch(0).deltaPosition;
        }

        //если нет касания
        return Vector2.zero;
    }

    public bool IsThereTouchOnScreen()
    {
        if (Input.touchCount > 0) return true;
        else return false;
    }

    private void Update()
    {
  //      Debug.Log(GetTouchDeltaPosition() + " Delta position ");
        Debug.Log(IsThereTouchOnScreen() + " touch on screen ");
    }
}