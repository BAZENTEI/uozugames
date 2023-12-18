using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // �V�[�������[�h���ꂽ�Ƃ���BGM�Đ�
        if (scene.name == "StageSelect")
        {
            // BGM�Đ��̃R�[�h
            //audioSource.Play();
        }
        // ���̃V�[���̏ꍇ�͒�~
        else
        {
            // BGM��~�̃R�[�h
            audioSource.Stop();
        }
    }
}
