using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _angleSpeed;
    public void Move(float angleDirection)
    {
        Vector3 offset = new Vector3(_angleSpeed*angleDirection, 0, _moveSpeed)* Time.deltaTime;
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

  

}
