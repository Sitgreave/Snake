using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digestion : MonoBehaviour
{
    [SerializeField] private ChainSpawner _chain;
    [SerializeField] private Mouth _mouth;

    public void DigestFood()
    {
        _mouth.ChewedObjects.Dequeue().Invoke();

    }
    public void Eat()
    {
        StartCoroutine(Eating());
    }

    private IEnumerator Eating()
    {
        for (int i = 0; i < _chain.SpawnedObjList.Count; i++)
        {
            _chain.SpawnedObjList[i].EatAnimation.Eat();
            yield return new WaitForSeconds(.1f);
        }
        TakeEvents.OnEated.Invoke();
    }

}
