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
        // シーンがロードされたときにBGM再生
        if (scene.name == "StageSelect")
        {
            // BGM再生のコード
            //audioSource.Play();
        }
        // 他のシーンの場合は停止
        else
        {
            // BGM停止のコード
            audioSource.Stop();
        }
    }
}
