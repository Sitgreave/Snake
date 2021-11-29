using System.Collections.Generic;
using UnityEngine;

public class Spreader : MonoBehaviour{
    private int idTemp;
    public void SpreadSurfaces (List<SurfaceSegment> surfaces, int id)
    {
        idTemp = id;
        while (idTemp < surfaces.Count) 
        { 
            if (idTemp != 0)
            {
                float z = (surfaces[idTemp].GetSegmentLength() + surfaces[idTemp - 1].GetSegmentLength()) / 2 + surfaces[idTemp - 1].MyTransform.position.z;
                surfaces[idTemp].MyTransform.position = NewPositionZ(z);
            }
            idTemp++;
        }
    }

    public int SetLastId()
    {
        return idTemp;
    }
    private Vector3 NewPositionZ(float z)
    {        
        return new Vector3(0, 0, z);
    }

    
}
