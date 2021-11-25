using System.Collections.Generic;
using UnityEngine;

public class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    protected T GetT;
    protected List<T> SpawnedObjList = new List<T>();

    [SerializeField] private Transform _parent;
    public Transform Parent => _parent;

    [SerializeField] private int _count;
    protected void SpawnAll(T obj)
    {
        for (int i = 0; i < _count; i++)
        {
            T GetT = Instantiate(obj, _parent);
            SpawnedObjList.Add(GetT);
        }
    }
    protected void SpawnSingle(T obj)
    {
            T GetT = Instantiate(obj, _parent);
            SpawnedObjList.Add(GetT);
    }
}


