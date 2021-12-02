using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _angleSpeed;
   [SerializeField] public float Direction = 0;
    private float _additionalMoveSpeed = 0;
    private float _additionalAngleSpeed = 0;

    private void Move(float angleDirection)
    {
        Vector3 offset = new Vector3(
            x: (_angleSpeed + _additionalAngleSpeed)*angleDirection, 
            y: 0, 
            z: _moveSpeed + _additionalMoveSpeed);
        _rigidbody.velocity = offset * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        Move(Direction);
    }

    public void SpeedChange(float move, float angle)
    {
        _additionalMoveSpeed = move;
        _additionalAngleSpeed = angle;
    }

}
