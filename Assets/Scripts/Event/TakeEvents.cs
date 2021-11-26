using UnityEngine.Events;

public class TakeEvents : UnityEngine.MonoBehaviour
{

    private UnityEvent _onCrystalTaked;
    private UnityEvent _onFoodTaked;
    private UnityEvent _onTrapTaked; 
    

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
