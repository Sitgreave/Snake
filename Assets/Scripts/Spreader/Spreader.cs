using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spreader : MonoBehaviour
{
    private float _surfaceLengthTemp = 0;

    public void SpreadSurfaces (List<SurfaceSegment> surfaces)
    {
        for (int i = 0; i < surfaces.Count; i++)
        {
            surfaces[i].transform.position += NewPositionZ();
            _surfaceLengthTemp += surfaces[i].GetSegmentLength();
        }
    }
    private Vector3 NewPositionZ()
    {        
        return new Vector3(0, 0, _surfaceLengthTemp);
    }

    
}
