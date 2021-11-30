using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private bool _hasFever = false;
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Mouth _mouth;
   
    public void SwitchColor()
    {
        _renderer.material.color = ColorSetter.GetColorFromStatus(StageColorType.Right);
    }
    public void FeverActive()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IEadible eadible))
        {
           _mouth.EatObject(eadible);
            Destroy(other.gameObject);
        }
    }
}