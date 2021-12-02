using UnityEngine;

public class SegmentAnimations : MonoBehaviour
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
        _animator.SetBool("Eat", false);
    }

    public void EndDestroy()
    {
        Destroy(gameObject);
    }
}
