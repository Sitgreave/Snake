using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentSpawner : Spawner<SnakeSegment>
{
    [SerializeField] private SnakeSegment _prefab;
    [SerializeField] private Transform _head;
    private int _lastSegmentId;

   

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.D)) AddSegment();
        if (Input.GetKeyUp(KeyCode.A)) DeleteSegment();
    }
    public void AddSegment()
    { 
        StartCoroutine(SegmentCreating());             
    }

    private IEnumerator SegmentCreating()
    {
        for (int i = 0; i < SpawnedObjList.Count; i++)
        {
            SpawnedObjList[i].EatAnimation.Eat();
            yield return new WaitForSeconds(.1f);
        }
        if (_lastSegmentId < Count)
        {
            CreateSegment();
            SnakeEvents.OnNewSegmentSpawned.Invoke();
        }
    }
    private void CreateSegment()
    {
        SpawnSingle(_prefab);
        _lastSegmentId = SpawnedObjList.Count - 1;
        if (_lastSegmentId == 0)
        {
            SpawnedObjList[0]._nextSegment = _head;
        }
        else SpawnedObjList[_lastSegmentId]._nextSegment = SpawnedObjList[_lastSegmentId - 1].transform;
    }
 
    public void DeleteSegment()
    {
        if(SpawnedObjList.Count > 0)
        {
            Destroy(SpawnedObjList[_lastSegmentId]);
            SpawnedObjList[_lastSegmentId].EatAnimation.StartDestroy();
            SpawnedObjList.RemoveAt(_lastSegmentId);
            _lastSegmentId--;
            SnakeEvents.OnSegmentDestroyed.Invoke();
        }
    }
}
