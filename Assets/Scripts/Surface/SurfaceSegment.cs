using UnityEngine;

public class SurfaceSegment : MonoBehaviour
{
    [SerializeField] private Transform _beginPosition;
    [SerializeField] private Transform _endPosition;

    public float GetSegmentLength()
    {
        return _endPosition.position.z - _beginPosition.position.z;
    }
}
