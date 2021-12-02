using System.Collections.Generic;
using UnityEngine;

public class Stage : Spawner<SurfaceSegment>
{
    [SerializeField] private List<SurfaceSegment> _surfaceSegmentPrefabs = new List<SurfaceSegment>();
    [SerializeField] private SurfaceSegment _stageBeginPrefab;
   [SerializeField] private Spreader _spreader;
    private int _currentLastId;
    private int _lastDestroyedId = 0;
    private const int _maxStageOnScene = 9;


    private void Start()
    {
        SpawnStage();

    }

    public void SpawnStage()
    {
        SpawnSingle(_stageBeginPrefab);
        SpawnAll(_surfaceSegmentPrefabs);
        _spreader.SpreadSurfaces(SpawnedObjList, _currentLastId);
        _currentLastId = SpawnedObjList.Count - 1;
    }

    public void DestroyOldStages()
    {
        if(SpawnedObjList.Count >= _maxStageOnScene)
        {
            for (int i = 0; i < Count; i++)
            {
                Destroy(SpawnedObjList[i + _lastDestroyedId].gameObject);
                SpawnedObjList.RemoveAt(i);
                _currentLastId--;
            }
            _lastDestroyedId = Count-1;
        }
    }
}
public enum StageColorType
{
    Right,
    Wrong
}