using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneManager : MonoBehaviour
{
    public GameObject camera_1, camera_2, camera_3;
    public GameObject buss;
    public List<Animator> characters;
    public AudioSource cheersSound;
    void Start()
    {
        StartCoroutine(CutScene());

    }
    IEnumerator CutScene()
    {
        yield return new WaitForSeconds(3.0f);
        camera_1.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        camera_2.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        buss.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        cheersSound.enabled =(true);
        FinalAnim();
        camera_3.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadSceneAsync("Loader");
    }
    public void FinalAnim()
    {
        foreach (Animator anim in characters)
        {
            anim.SetTrigger("Dance");
        }
    }
}
