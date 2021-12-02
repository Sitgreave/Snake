using UnityEngine;

public class FoodSpawner : Spawner <FoodCell>
{

    [SerializeField] private SurfaceSegment _surface;
    private float _offsetZ;
    private float _offsetY;
    private float _tempZ;
    private float _segmentWidth;
    private void Start()
    {
        SpawnAll();
        SetOffsets();
       Invoke(nameof(GetNewPositions), .01f);
    }

    private void GetNewPositions()
    {
        _tempZ = _surface.Measurer.BeginZ();
        for (int i = 0; i < SpawnedObjList.Count; i++)
        {
            _tempZ += _offsetZ;
            SpawnedObjList[i].transform.position = PositionWithOffsets(); 
        }
    }
    private void SetOffsets()
    {
        _offsetZ = _surface.Measurer.MinimumDistanceBetweenObj_Z(SpawnedObjList.Count);
       
        _offsetY = SpawnedObjList[0].GetHeightOffset + SpawnedObjList[0].Parent.transform.position.y; 
        _segmentWidth = _surface.Measurer.SurfaceWidth() - 1.6f;
    }
    private Vector3 PositionWithOffsets()
    {
        return new Vector3(
            x: Offset_X(),
            y: _offsetY,
            z: _tempZ
            ) ; 
    }
    private float Offset_X()
    {        
        float right = _segmentWidth/ 2;
        float left = right * -1;
        float result = 0;
        int sideId = Random.Range(0,2);
        switch (sideId)
        { 
            case 0: result = left; break;
            case 1: result = right; break;
        }
        return result + Random.Range(-0.2f, .2f);
    }

   

    
   
}
