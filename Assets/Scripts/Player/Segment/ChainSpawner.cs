using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSpawner : Spawner<ChainSegment>
{
    [SerializeField] private Transform _head;
    [SerializeField] private Fever _fever;
    private int _lastSegmentId => SpawnedObjList.Count - 1;
    public int CurrentCount => _lastSegmentId;
    public float FeverTime => _fever.Time;

   [SerializeField] private void CreateSegment()
    {
        if (_lastSegmentId < Count)
        {
            SpawnSingle();
            if (_lastSegmentId == 0)
            {
                SpawnedObjList[0]._nextSegment = _head;
            }
            else SpawnedObjList[_lastSegmentId]._nextSegment = SpawnedObjList[_lastSegmentId - 1].transform;
          
            SnakeEvents.OnSegmentCountChanged.Invoke();
        }
        else DeleteSegment(3);
        
    }

  [SerializeField] private void DeleteSegment(int count)
    {
        if (!_fever.HasFever)
        {
            for (int i = 0; i < count; i++)
            {
                if (SpawnedObjList.Count > 0)
                {
                    SpawnedObjList[_lastSegmentId].EatAnimation.StartDestroy();
                    Destroy(SpawnedObjList[_lastSegmentId]);
                    SpawnedObjList.RemoveAt(_lastSegmentId);
                }
                else if (SpawnedObjList.Count == 0)
                {
                    Destroy(_head.gameObject);
                    break;
                }
            }
        }
        SnakeEvents.OnSegmentCountChanged.Invoke();
    }
}
