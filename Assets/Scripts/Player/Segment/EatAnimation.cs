using UnityEngine;

public class EatAnimation : MonoBehaviour
{
    public Animator _animator;


    private void StopEat()
    {
        _animator.SetBool("Eat", false);
    }
    public void Eat()
    {
        _animator.SetBool("Eat", true);
    }
    public void StartDestroy()
    {
        _animator.SetBool("Destroy", true);
    }

    public void EndDestroy()
    {
        Destroy(gameObject);
    }
}
