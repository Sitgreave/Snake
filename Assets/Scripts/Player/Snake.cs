using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    private bool _hasFever = false;
    [SerializeField] private MeshRenderer _renderer;
  
    public delegate void Action();
    private Queue<Action> _eatedObjects = new Queue<Action>();
    public Queue<Action> EatedObjects => _eatedObjects;
    public void SwitchColor()
    {
        _renderer.material.color = ColorSetter.GetColorFromStatus(StageColorType.Right);
    }
    public void FeverActive()
    {

    }
    private void TakeFood()
    {
        TakeEvents.OnFoodTaked.Invoke();
    }
    private void EatObject(IEadible obj) 
    {
        _eatedObjects.Enqueue(obj.Digest);
        TakeEvents.OnContacted.Invoke();
    }

    private void TakeDamage()
    {
        TakeEvents.OnTrapTaked.Invoke();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IEadible eadible))
        {
           EatObject(eadible);
           eadible.DisappearingInMouth();
        }
    }
}