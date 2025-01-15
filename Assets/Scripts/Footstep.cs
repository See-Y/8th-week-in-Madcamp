using UnityEngine;

public class Footstep : MonoBehaviour
{
    public AudioClip footstepClip; // 발소리 오디오 클립

    public AudioSource audioSource;
    private bool isPlaying = false;
    private Vector3 lastPosition;

    void Start()
    {
        // AudioSource 기본 설정
        audioSource.clip = footstepClip;
        lastPosition = transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, lastPosition) > 0.0f)
        {
            if (!isPlaying)
            {
                PlayFootstepSound();
                isPlaying = true;
            }
        }
        else
        {
            StopSound();
            isPlaying = false;
        }
        lastPosition = transform.position;
    }

    private void PlayFootstepSound()
    {
        audioSource.PlayOneShot(footstepClip);
    }
    public void StopSound()
    {
        audioSource.Stop(); // 효과음 멈춤
    }
}
