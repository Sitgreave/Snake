using UnityEngine;

public class FoodSpawner : Spawner <FoodCell>
{
    [SerializeField] private FoodCell _cellPrefab;
    [SerializeField] private SurfaceSegment _foodSegment;
    private float _offsetZ;
    private float _offsetY;
    private float _tempZ = 0;
    private float _segmentWidth;
    private void Start()
    {
        SpawnAll(_cellPrefab);
        _offsetZ = (_foodSegment.GetSegmentLength() - 2) / SpawnedObjList.Count;
       _offsetY = _cellPrefab.GetHeightOffset() + SpawnedObjList[0].transform.position.y;
        _segmentWidth = _foodSegment.GetSegmentWidth() - 1;
        for (int i = 0; i < SpawnedObjList.Count; i++)
        {
            SpawnedObjList[i].transform.position = PositionWithOffsets(SpawnedObjList[i].transform.position);
            _tempZ += _offsetZ;
        }
        
    }


    private Vector3 PositionWithOffsets(Vector3 startPosition)
    {
        return new Vector3(x: Offset_X(), y: _offsetY, z: startPosition.z + _tempZ + Random.Range(0,2));
    }
    private float Offset_X()
    {
        float left = (_segmentWidth / 2) * -1;
        float right = _segmentWidth / 2;
        int sideId = Random.Range(0,2);
        switch (sideId)
        { 
            case 0: return left;
            case 1: return right;
        }
        return 0;
    }

   

    
   
}
