using UnityEngine;

public class FoodCell : Spawner <Food>
{
    [SerializeField] private FoodSpreader _spreader;
    private StageColorType _colorType;
    public StageColorType ColorType => _colorType; 
    public float GetHeightOffset => GetT.GetHeightOffset();
    public float CellDiameter => _spreader.Diameter;

    private void Start()
    {      
        FoodCellCreate();
        SetColorType();
    }
    private void SetColorType()
    {
        int typeId = Random.Range(1, 3);
        switch (typeId)
        {
            case 1:
                _colorType = StageColorType.Right;
                break;
            case 2:
                _colorType = StageColorType.Wrong;
                break;
        }
        for (int i = 0; i < SpawnedObjList.Count; i++)
        {
            SpawnedObjList[i].SetColor(ColorSetter.GetColorFromStatus(_colorType), _colorType);
        }

    }
    private void FoodCellCreate()
    {
        SpawnAll();
        _spreader.SpreadFood();
    }
   

    
}
