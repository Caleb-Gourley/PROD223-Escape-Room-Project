using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketInteractionManager : MonoBehaviour
{
    public int Puzzle_1_Count;
    public int Puzzle_2_Count;
    public GameObject Puzzle_1_Trophy;
    public GameObject Puzzle_2_Trophy;

    // Update is called once per frame
    void Update()
    {
        if (Puzzle_1_Count == 3)
        {
            Puzzle_1_Trophy.SetActive(true);
        }

        if (Puzzle_2_Count == 2)
        {
            Puzzle_2_Trophy.SetActive(true);
        }
    }
}
