using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  PlaceSetter : MonoBehaviour
{
    private float minX, minZ; 
    private float maxX, maxZ; 
    private float minDist; 
                             
    public Vector3 PlacementPosition(Transform platform, string prefab_tag)
    {
        Collider[] nearColliders;
        bool placeNear = false;
        float y = platform.position.y;
        while (true)
        {
            float x = Random.Range(minX, maxX) + platform.position.x; 
            float z = Random.Range(minZ, maxZ) + platform.position.z; 
            
            nearColliders = Physics.OverlapSphere(new Vector3(x, y, z), minDist); 
            foreach (Collider col in nearColliders)
            {
                if (col.CompareTag(prefab_tag))
                {
                    placeNear = true;
                    break;
                }
            }
            if (!placeNear)
            {
                return new Vector3(x, y, z);
            }
        }
    } 
        
    }

