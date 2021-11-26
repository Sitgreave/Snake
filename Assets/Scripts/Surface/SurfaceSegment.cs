using UnityEngine;

public class SurfaceSegment : MonoBehaviour
{
    [SerializeField] private BoxCollider _boxCollider;
    [SerializeField] private Transform _transform;
    public Transform MyTransform => _transform;
    private StageColorType _colorType;
    public StageColorType ColorType => _colorType;
    private Color _rightColor;
    private Color _wrongColor;
    private void Start()
    {
        StageEvents.OnSegmentSpawned.Invoke();
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 5);
        }
    }
    private void SetColorType()
    {
        int typeId = Random.Range(1, 3);
        switch (typeId)
        {
            case 1:
                _colorType = StageColorType.Right;
                break;
            case 2:
                _colorType = StageColorType.Wrong;
                break;
        }

    }
    public float GetSegmentLength()
    {
        float a = _boxCollider.size.z * transform.localScale.z ;
        return a;
    }
    public float GetSegmentWidth()
    {
        return Mathf.Abs (_boxCollider.size.x * transform.localScale.x);
    }
}
