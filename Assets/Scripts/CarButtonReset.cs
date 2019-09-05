using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarButtonReset : MonoBehaviour
{
    public void RestartGame() {
        SceneManager.LoadScene("Car-As1");
    }
}
