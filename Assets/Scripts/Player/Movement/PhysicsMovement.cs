using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _angleSpeed;
   [SerializeField] public float Direction = 0;
    
    private void Move(float angleDirection)
    {
        Vector3 offset = new Vector3(_angleSpeed*angleDirection, 0, _moveSpeed);
        _rigidbody.velocity = offset * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        Move(Direction);
    }



}
