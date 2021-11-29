using UnityEngine;

public class TouchInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;
    private int _screenWidth = Screen.width;
       
        void Update()
        {
            float currentDirection = 0;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                currentDirection = TouchInterpretation(touch.position.x);
            }
            _movement.Direction = currentDirection;
        }

        private float TouchInterpretation(float touchPositionX)
        {          
            touchPositionX /= _screenWidth;
            if (touchPositionX < .5) return -1;
            else return 1;
        }
    }

