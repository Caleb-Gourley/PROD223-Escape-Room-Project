using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SocketInteractionManager : MonoBehaviour
{
    public int Puzzle_1_Count;
    public int Puzzle_2_Count;
    public bool IsPuzzle_3_Complete;
    public int Trophy_Count;
    public bool Key_Count;
    public GameObject Puzzle_1_Trophy;
    public GameObject Puzzle_2_Trophy;
    public GameObject Puzzle_3_Trophy;
    public GameObject Key;
    public AudioSource Alert_Sound;

    void Start()
    {
        Puzzle_1_Trophy.SetActive(false);
        Puzzle_2_Trophy.SetActive(false);
        Puzzle_3_Trophy.SetActive(false);
        Key.SetActive(false);
        Alert_Sound.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Puzzle_1_Count == 3)
        {
            Puzzle_1_Trophy.SetActive(true);
            Alert_Sound.Play();
        }

        if (Puzzle_2_Count == 2)
        {
            Puzzle_2_Trophy.SetActive(true);
            Alert_Sound.Play();
        }

        if(IsPuzzle_3_Complete)
        {
            Puzzle_3_Trophy.SetActive(true);
            Alert_Sound.Play();
        }

        if(Trophy_Count == 3)
        {
            Key.SetActive(true);
            Alert_Sound.Play();
        }

        if(Key_Count)
        {
            // end screen
            Debug.Log("Win");
            WaitForEndScreen();
        }
    }

    public IEnumerator WaitForEndScreen()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Game_Over");
    }
}
