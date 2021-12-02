
using UnityEngine;

public class Bomb : MonoBehaviour, IEadible
{
    public void DigestResult()
    {
        TakeEvents.OnBombDigested.Invoke();
    }
}
