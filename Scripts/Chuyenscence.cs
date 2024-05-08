using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chuyenscence : MonoBehaviour
{
    public void choivoinguoi(){
        SceneManager.LoadScene("Game");
    }
    public void choivoimay(){
        SceneManager.LoadScene("SampleScene");
    }
    public void dauhang(){
        SceneManager.LoadScene("MainMenu");
    }
    public void thoat(){
        SceneManager.LoadScene("MainMenu");
    }
    public void huongdan(){
        SceneManager.LoadScene("Huongdan");
    }
}
