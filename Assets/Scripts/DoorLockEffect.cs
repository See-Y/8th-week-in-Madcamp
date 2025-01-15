using UnityEngine;

public class DoorLockEffect : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;
    public void PlaySound()
    {
        audioSource.PlayOneShot(soundEffect); // 효과음 재생
    }
    public void StopSound()
    {
        audioSource.Stop(); // 효과음 멈춤
    }
}
