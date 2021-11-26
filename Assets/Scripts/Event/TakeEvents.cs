using UnityEngine.Events;
using UnityEngine;
public class TakeEvents : MonoBehaviour
{

   [SerializeField]  private UnityEvent _onCrystalTaked;
   [SerializeField] private UnityEvent _onFoodTaked;
   [SerializeField] private UnityEvent _onTrapTaked; 
    

    public static UnityEvent OnCrystalTaked;
    public static UnityEvent OnFoodTaked;
    public static UnityEvent OnTrapTaked;

    private void Awake()
    {
        _onCrystalTaked = OnCrystalTaked;
        _onFoodTaked = OnFoodTaked;
        _onTrapTaked = OnTrapTaked;
    }

}
