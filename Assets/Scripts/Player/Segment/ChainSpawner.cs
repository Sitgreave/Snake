using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSpawner : Spawner<ChainSegment>
{
    [SerializeField] private ChainSegment _prefab;
    [SerializeField] private Transform _head;
    private int _lastSegmentId => SpawnedObjList.Count - 1;
    

   

    private void Update()
    {
        //if (Input.GetKeyUp(KeyCode.D)) AddSegment();
        if (Input.GetKeyUp(KeyCode.A)) DeleteSegment();
    }


    public void CreateSegment()
    {
        if (_lastSegmentId < Count)
        {
            SpawnSingle(_prefab);
            if (_lastSegmentId == 0)
            {
                SpawnedObjList[0]._nextSegment = _head;
            }
            else SpawnedObjList[_lastSegmentId]._nextSegment = SpawnedObjList[_lastSegmentId - 1].transform;
            SnakeEvents.OnNewSegmentSpawned.Invoke();
        }
    }
 
    public void DeleteSegment()
    {
        if(SpawnedObjList.Count > 0)
        {
            SpawnedObjList[_lastSegmentId].EatAnimation.StartDestroy();
            Destroy(SpawnedObjList[_lastSegmentId]);
            SpawnedObjList.RemoveAt(_lastSegmentId);
            SnakeEvents.OnSegmentDestroyed.Invoke();
        }
    }
}
