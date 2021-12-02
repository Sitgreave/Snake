using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected T GetT;
    private List<T> _spawnedObjList = new List<T>();
    public List<T> SpawnedObjList => _spawnedObjList;

    [SerializeField] private Transform _parent;
    public Transform Parent => _parent;
    
    [SerializeField] private int _count;
    public int Count => _count;

    protected void SpawnAll()
    {
        for (int i = 0; i < _count; i++)
        {
            T newT = Instantiate(GetT, _parent);
            SpawnedObjList.Add(newT);
        }
    } protected void SpawnAll(List<T> obj) 
    {
        for (int i = 0; i < _count; i++)
        {            
            T newT = Instantiate(obj[GetRandomId(obj.Count)], _parent);
            SpawnedObjList.Add(newT);
        }
    }
     private int GetRandomId(int max)
    {
        return Random.Range(0, max);
    }
    protected void SpawnSingle()
    {
        T newT = Instantiate(GetT, _parent);
        SpawnedObjList.Add(newT);
    }    
    protected void SpawnSingle(T obj)
    {
        T newT = Instantiate(obj, _parent);
        SpawnedObjList.Add(newT);
    }
}



