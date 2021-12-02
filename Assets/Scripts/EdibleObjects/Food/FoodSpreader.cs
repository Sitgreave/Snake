using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpreader : MonoBehaviour
{
    [SerializeField] private FoodCell _cell;
    [SerializeField] [Range(.1f, 1)] private float _radius; 
    private const float PI = 3.14159f;
    public float Diameter => _radius * 2 * transform.localScale.z;
    private int _foodInCellCount => _cell.SpawnedObjList.Count;

    public void SpreadFood()
    {
        FoodArrangeInCircle();
        RandomFoodDisable();
    }
  

    private void FoodArrangeInCircle()
    {
        if (_foodInCellCount > 0)
        {
            for (int i = 0; i < _foodInCellCount; i++)
            {
                float angle = i * PI * 2f / (_foodInCellCount - 1);

                Vector3 newPos = new Vector3(
                    x: Mathf.Cos(angle) * _radius + _cell.Parent.position.x,
                    y: _cell.Parent.position.y,
                    z: Mathf.Sin(angle) * _radius + _cell.Parent.position.z
                    ) ;

                _cell.SpawnedObjList[i].transform.position = newPos;
            }
            _cell.SpawnedObjList[_foodInCellCount - 1].transform.position = _cell.Parent.position;
        }
    }

    private void RandomFoodDisable()
    {
        int disableCount = Random.Range(0, _foodInCellCount / 2 + 1);
        for (int i = 0; i < disableCount; i++)
        {
            int randomFoodId = Random.Range(0, _foodInCellCount);
            Destroy(_cell.SpawnedObjList[randomFoodId].gameObject);
        }
    }

}

