using UnityEngine;

public class Sneak : MonoBehaviour
{
    private bool _hasFever = false;
    [SerializeField] private MeshRenderer _meshRenderer;
    
   public void SwitchColor()
    {
       _meshRenderer.material.color = ColorSetter.GetColorFromStatus(StageColorType.Right);
    }
    public void FeverActive ()
    {

    }
    private void TakeFood()
    {
        //TakeEvents.OnFoodTaked.Invoke();
    }
    private void EatObject<T>(T obj) where T : MonoBehaviour
    {
        Destroy(obj.gameObject);
    }

    private void TakeDamage()
    {
        
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Food":
                Food food;
                if (food = other.GetComponent<Food>())
                {
                    if (food.MyColorType == StageColorType.Right)
                    {
                        TakeFood();
                    }
                    else
                    {
                        if (_hasFever) TakeFood();
                        else TakeDamage();
                    }
                    EatObject(food);
                }
                    break;
                
            case "Trap": TakeDamage();  
                TakeEvents.OnTrapTaked.Invoke(); 
                break;

            case "Crystal": TakeEvents.OnCrystalTaked.Invoke();
                break;
        }
    }
}
