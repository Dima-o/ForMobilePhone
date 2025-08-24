using UnityEngine;

public class InputHandler : MonoBehaviour
{

    public Vector2 GetTouchDeltaPosition()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    break;

                case TouchPhase.Moved:
                    return touch.deltaPosition;
                
                case TouchPhase.Ended:
                    break;
            }
        }
        return Vector2.zero;
    }

    public bool IsThereTouchOnScreen()
    {
        bool result = (Input.touchCount > 0) ? true : false;
        return result;
    }
}
