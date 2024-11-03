using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource; // ���ڲ�����Ƶ
    public AudioClip audioClip; // ָ��Ҫ���ŵ���ƵƬ��

    private bool isPlaying = false; // �����Ƶ�Ƿ����ڲ���

    // ���š���ͣ�������Ƶ�ķ���
    public void ToggleAudio()
    {
        if (audioClip != null)
        {
            if (!isPlaying)
            {
                audioSource.clip = audioClip;
                audioSource.Play();
                isPlaying = true; // ���Ϊ���ڲ���
            }
            else
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Pause(); // ��ͣ����
                }
                else
                {
                    audioSource.UnPause(); // ��������
                }
            }
        }
    }
}
