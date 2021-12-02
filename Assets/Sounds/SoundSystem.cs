using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    [SerializeField] private List<AudioClip> _eatSounds;
    [SerializeField] private AudioClip _newColorSound;
    [SerializeField] private AudioClip _bubleSound;
    [SerializeField] private AudioClip _badBubleSound;
    [SerializeField] private AudioSource _source;


    private void Start()
    {
        StartCoroutine(Pitcher());
    }
    public void PlayEatSound()
    {
        int randomIndex = Random.Range(0, _eatSounds.Count);
        _source.pitch = Random.Range(.9f, 1.1f);
        PlayClip(_eatSounds[randomIndex]);
    }
    public void PlayBubleSound()
    {
        _source.pitch += .05f;
        PlayClip(_bubleSound);
    }
    public void PlaySwitchColorSound()
    {
        _source.pitch += .1f;
        PlayClip(_newColorSound);
    }
    public void PlayBadEatSound()
    {
        _source.pitch += .05f;
        PlayClip(_badBubleSound);
    }
    private void PlayClip(AudioClip clip)
    {
      
        _source.PlayOneShot(clip);
    }
    IEnumerator Pitcher()
    {
        while (true)
        {
            if (!_source.isPlaying && _source.pitch != 1) _source.pitch = 1f;
            yield return new WaitForSeconds(1);
        }
    }

}
