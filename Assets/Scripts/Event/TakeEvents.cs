using UnityEngine.Events;
using UnityEngine;
public class TakeEvents : MonoBehaviour
{

   [SerializeField]  private UnityEvent _onCrystalTaked;
   [SerializeField] private UnityEvent _onFoodTaked;
   [SerializeField] private UnityEvent _onTrapTaked;
   [SerializeField] private UnityEvent _onEated;
   [SerializeField] private UnityEvent _onContacted;
    public static UnityEvent OnEated;
    public static UnityEvent OnCrystalTaked;
    public static UnityEvent OnFoodTaked;
    public static UnityEvent OnTrapTaked;
    public static UnityEvent OnContacted;

    private void Awake()
    {
        OnEated = _onEated;
        OnCrystalTaked = _onCrystalTaked;
        OnFoodTaked =_onFoodTaked;
        OnTrapTaked = _onTrapTaked;
        OnContacted = _onContacted;
    }

}
