using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Food : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private CapsuleCollider _collider;
    private StageColorType _myColorStatus;
    public float GetHeightOffset()
    {
        return (_collider.height * transform.localScale.y) / 2;
    }
    public void SetColor(Color color)
    {
        _meshRenderer.material.color = color;
    }
}


