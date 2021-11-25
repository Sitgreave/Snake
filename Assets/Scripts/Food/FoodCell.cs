using UnityEngine;

public class FoodCell : Spawner <Food>
{
    [SerializeField] private Food _food;
    [SerializeField] [Range(.1f, 1)] private float _radius;
    private const float PI = 3.14159f;
    public float GetHeightOffset() => _food.GetHeightOffset();
    private StageColorType _colorType;
    public StageColorType ColorType => _colorType; 

    private void Start()
    {      
        FoodCellCreate();
        SetColorType();
        for (int i = 0; i < SpawnedObjList.Count; i++)
        {
            SpawnedObjList[i].SetColor(ColorSetter.GetColorFromStatus(_colorType));
        }
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
       
    }
    private void FoodCellCreate()
    {
        SpawnAll(_food);
        FoodArrangeInCircle();
        RandomFoodDisable();
    }
    private void FoodArrangeInCircle()
    {
        if (SpawnedObjList.Count > 0)
        {
            for (int i = 0; i < SpawnedObjList.Count; i++)
            {
                float angle = i * PI * 2f / (SpawnedObjList.Count - 1);
                Vector3 newPos = new Vector3((Mathf.Cos(angle) * _radius) + Parent.position.x, Parent.position.y, (Mathf.Sin(angle) * _radius + Parent.position.z));
                SpawnedObjList[i].transform.position = newPos;
            }
            SpawnedObjList[SpawnedObjList.Count - 1].transform.position = Parent.position;
        }
    }

    private void RandomFoodDisable()
    {
        int disableCount = Random.Range(0, (SpawnedObjList.Count+1) / 2);
        for (int i = 0; i < disableCount; i++)
        {
            int randomFoodId = Random.Range(0, SpawnedObjList.Count);
            Destroy(SpawnedObjList[randomFoodId]);
        }
    }
}
