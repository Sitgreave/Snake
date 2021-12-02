using UnityEngine.Events;
using UnityEngine;
public class TakeEvents : MonoBehaviour
{

   [SerializeField]  private UnityEvent _onCrystalTaked;
   [SerializeField] private UnityEvent _onGoodFoodDigested;
   [SerializeField] private UnityEvent _onBadFoodDigested;
   [SerializeField] private UnityEvent _onBombDigested;
   [SerializeField] private UnityEvent _onEated;
   [SerializeField] private UnityEvent _onContacted;
    public static UnityEvent OnEated;
    public static UnityEvent OnCrystalTaked;
    public static UnityEvent OnGoodFoodDigested;
    public static UnityEvent OnBadFoodDigested;
    public static UnityEvent OnContacted;
    public static UnityEvent OnBombDigested;

    private void Awake()
    {
        OnEated = _onEated;
        OnCrystalTaked = _onCrystalTaked;
        OnGoodFoodDigested = _onGoodFoodDigested;
        OnBadFoodDigested = _onBadFoodDigested;
        OnContacted = _onContacted;
        OnBombDigested = _onBombDigested;
    }

}
