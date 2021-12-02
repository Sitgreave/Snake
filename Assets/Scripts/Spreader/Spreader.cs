using System.Collections.Generic;
using UnityEngine;

public class Spreader : MonoBehaviour
{
    public void SpreadSurfaces(List<SurfaceSegment> surfaces, int id)
    {
        while (id < surfaces.Count)
        {
            if (id != 0)
            {
                float z = (surfaces[id].Measurer.SurfaceLength() + surfaces[id - 1].Measurer.SurfaceLength()) / 2 + surfaces[id - 1].MyTransform.position.z;
                surfaces[id].MyTransform.position = NewPositionZ(z);
            }
            id++;
        }
    }


    private Vector3 NewPositionZ(float z)
    {
        return new Vector3(0, 0, z);
    }


}
