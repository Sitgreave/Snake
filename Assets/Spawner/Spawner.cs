using System.Collections.Generic;
using UnityEngine;

public class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    protected T GetT;
    private List<T> _spawnedObjList = new List<T>();
    public List<T> SpawnedObjList => _spawnedObjList;

    [SerializeField] private Transform _parent;
    public Transform Parent => _parent;

    [SerializeField] private int _count;
    public int Count => _count;

    protected void SpawnAll(T obj)
    {
        for (int i = 0; i < _count; i++)
        {
            T GetT = Instantiate(obj, _parent);
            SpawnedObjList.Add(GetT);
        }
    } protected void SpawnAll(List<T> obj) 
    {
        for (int i = 0; i < _count; i++)
        {            
            T GetT = Instantiate(obj[GetRandomId(obj.Count)], _parent);
            SpawnedObjList.Add(GetT);
        }
    }
     private int GetRandomId(int max)
    {
        return Random.Range(0, max);
    }
    protected void SpawnSingle(T obj)
    {
            T GetT = Instantiate(obj, _parent);
            SpawnedObjList.Add(GetT);
    }
}



