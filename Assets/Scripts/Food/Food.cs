using UnityEngine;

public class Food : MonoBehaviour, IMagnetically
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private CapsuleCollider _collider;
    
    private StageColorType _myColorType;
    public StageColorType MyColorType => _myColorType;
    public float GetHeightOffset()
    {
        return (_collider.height * transform.localScale.y) / 2;
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


