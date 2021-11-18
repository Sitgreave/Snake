using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentSpawner : MonoBehaviour
{

    [SerializeField] private SurfaceSegment _surfaceSegmentPrefab;
    [SerializeField] private Transform _transformParent;
    private List<SurfaceSegment> _surfaceSegments = new List<SurfaceSegment>();

    public void Spawn(int count)
    {
        float temp = 0;
        for (int i = 0; i < count; i++)
        {
            SurfaceSegment newSegment = Instantiate(_surfaceSegmentPrefab, _transformParent);
            newSegment.transform.position = new Vector3(0, 0, temp);
            temp += newSegment.GetSegmentLength();
            _surfaceSegments.Add(newSegment);
        }
    }
}
