using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource; // 用于播放音频
    public AudioClip audioClip; // 指定要播放的音频片段

    private bool isPlaying = false; // 标记音频是否正在播放

    // 播放、暂停或继续音频的方法
    public void ToggleAudio()
    {
        if (audioClip != null)
        {
            if (!isPlaying)
            {
                audioSource.clip = audioClip;
                audioSource.Play();
                isPlaying = true; // 标记为正在播放
            }
            else
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Pause(); // 暂停播放
                }
                else
                {
                    audioSource.UnPause(); // 继续播放
                }
            }
        }
    }
}
