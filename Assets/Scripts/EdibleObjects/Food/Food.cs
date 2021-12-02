using UnityEngine;

public class Food : MonoBehaviour, IMagnetically, IEadible
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private CapsuleCollider _colliderObj;
    public float GetHeightOffset()
    {
        return Mathf.Abs(_colliderObj.height * transform.localScale.y)/2;
    }
    private StageColorType _myColorType;
    public void DigestResult()
    {
        if (_myColorType == StageColorType.Right) TakeEvents.OnGoodFoodDigested.Invoke();
        else TakeEvents.OnBadFoodDigested.Invoke();
    }
    public void Magnetized()
    {
       //play sound, animation, etc
    }

    public void SetColor(Color color, StageColorType stageColorType)
    {
        _meshRenderer.material.color = color;
        _myColorType = stageColorType;
    }
}


