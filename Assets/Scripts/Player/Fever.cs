using UnityEngine;

public class Fever : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;
    [SerializeField] [Range(10, 50)] private float _accelerationX;
    [SerializeField] [Range(50, 200)] private float _accelerationZ;
    [SerializeField] private float _time;
    public float Time => _time;

    private bool _hasFever = false;
    public bool HasFever => _hasFever;
    [SerializeField]
    private void FeverBegin()
    {
        Active();
        Invoke(nameof(Deactive), _time);
    }

    private void Active()
    {
        _movement.SpeedChange(_accelerationX, _accelerationZ);
        _hasFever = true;
    }
    private void Deactive()
    {
        _movement.SpeedChange(0, 0);
        _hasFever = false;
    }

}
