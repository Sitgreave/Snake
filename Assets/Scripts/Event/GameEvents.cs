using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    public static UnityEvent OnLevelLosed;
   [SerializeField] private UnityEvent _onLevelLosed;
    public UnityEvent OnLevelWon;

    private void Start()
    {
        OnLevelLosed = _onLevelLosed;
    }

}
