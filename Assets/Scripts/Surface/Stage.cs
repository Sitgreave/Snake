using System.Collections.Generic;
using UnityEngine;

public class Stage : Spawner<SurfaceSegment>
{
    [SerializeField] private List<SurfaceSegment> _surfaceSegmentPrefabs = new List<SurfaceSegment>();
    [SerializeField] private SurfaceSegment _stageFinishPrefab;
    [SerializeField] private Spreader _spreader;
    private void Start()
    {
        SpawnStage();
    
    }

    public void SpawnStage()
    {
        SpawnSingle(_stageFinishPrefab);
        SpawnAll(_surfaceSegmentPrefabs[RandomSegmentId()]);
        _spreader.SpreadSurfaces(SpawnedObjList);
        SpawnedObjList.Clear();
    }

    private int RandomSegmentId()
    {
        return Random.Range(0, _surfaceSegmentPrefabs.Count);
    }
}
public enum StageColorType
{
    Right,
    Wrong
}