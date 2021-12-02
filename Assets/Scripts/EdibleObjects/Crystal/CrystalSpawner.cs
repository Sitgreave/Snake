using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpawner : Spawner <Crystal>
{
    [SerializeField] private Transform _trapTransform;
    [SerializeField] [Range(.5f, 2)] private float _radius;

    void Start()
    {
        SpawnSingle();
        ArrangeAroundTrap();
    }

   
    private void ArrangeAroundTrap()
    {
        Vector3 newPosition = RandomCircle(_trapTransform.position, _radius);
        SpawnedObjList[0].transform.position = newPosition;
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }

}
