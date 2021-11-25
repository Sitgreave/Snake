using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StageEvents.OnStageCompleted.Invoke();
            Debug.Log("A");
        }
    }
}
