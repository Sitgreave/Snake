using UnityEngine;

public class SurfaceSegment : MonoBehaviour
{
    [SerializeField] private Transform _beginPosition;
    [SerializeField] private Transform _endPosition;
    private StageColorType _colorType;
    public StageColorType ColorType => _colorType;
    private Color _rightColor;
    private Color _wrongColor;
    private void Start()
    {
        StageEvents.OnSegmentSpawned.Invoke();
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
        return Mathf.Abs(_endPosition.position.z - _beginPosition.position.z);
    }
    public float GetSegmentWidth()
    {
        return Mathf.Abs (_endPosition.position.x - _beginPosition.position.x);
    }
}
