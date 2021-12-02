using UnityEngine;

public class SurfaceSegment : MonoBehaviour
{
    [SerializeField] private BoxCollider _boxCollider;
    [SerializeField] private Transform _transform;
    [SerializeField] private Measurer _measurer;
    public Measurer Measurer => _measurer;

    private bool _playerExit;
    public Transform MyTransform => _transform;
    private StageColorType _colorType;
    public StageColorType ColorType => _colorType;

    private void Start()
    {
        StageEvents.OnSegmentSpawned.Invoke();
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerExit = true;
            Invoke(nameof(DestroySegment), 1);
        }
    }

    private void DestroySegment()
    {
        if (_playerExit)
        {
            Destroy(gameObject, 3);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerExit = false;
        }
    }



}
