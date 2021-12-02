using UnityEngine;

public class Measurer : MonoBehaviour
{
    [SerializeField] private BoxCollider _colliderSurface;
    private const float _lengthOffset = 0;
    public float SurfaceLength()
    {
        return _colliderSurface.size.z * _colliderSurface.transform.localScale.z;
    }
    public float SurfaceWidth()
    {
        return Mathf.Abs(_colliderSurface.size.x * _colliderSurface.gameObject.transform.localScale.x);
    }
    public float MinimumDistanceBetweenObj_Z(float objCount)
    {
        return (SurfaceLength() - _lengthOffset) / (objCount );
    }

    public float BeginZ()
    {
        return _colliderSurface.bounds.min.z;
    }
}
