using UnityEngine;

public class Sneak : MonoBehaviour
{
    private bool _hasFever = false;
    
    private void EatObject<T>() where T : MonoBehaviour
    {

    }
    public void FeverActive ()
    {

    }
    private void TakeFood(Food food)
    {
        TakeEvents.OnFoodTaked.Invoke();
    }

    private void TakeDamage()
    {
        
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Food":
                Food food = GetComponent<Food>();
                if (food.MyColorType == StageColorType.Right)
                {
                    TakeFood(food);
                }
                else
                {
                    if (_hasFever) TakeFood(food);
                        else TakeDamage();
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
