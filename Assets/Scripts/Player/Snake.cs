
using UnityEngine;

public class Snake : MonoBehaviour
{
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Mouth _mouth;
    
    public void SwitchColor()
    {
        _renderer.material.color = ColorSetter.GetColorFromStatus(StageColorType.Right);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IEadible eadible))
        {
           _mouth.EatObject(eadible);
            Destroy(other.gameObject);
        }
    }

    private void OnDestroy()
    {
        GameEvents.OnLevelLosed.Invoke();
    }

}