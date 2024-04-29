using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public InteractableManager Puzzle_2_List;

    void Start()
    {
        Puzzle_1_Trophy.SetActive(false);
        Puzzle_2_Trophy.SetActive(false);
        Puzzle_3_Trophy.SetActive(false);
        Key.SetActive(false);
    }

    void Update()
    {
        if (Puzzle_1_Count == 3)
        {
            Puzzle_1_Trophy.SetActive(true);
        }

        if (Puzzle_2_Count == 2)
        {
            Puzzle_2_Trophy.SetActive(true);
            Puzzle_2_List = GetComponent<InteractableManager>();
            Puzzle_2_List.interactableObjectsRed.Clear();
        }

        if(IsPuzzle_3_Complete)
        {
            Puzzle_3_Trophy.SetActive(true);
        }

        if(Trophy_Count == 3)
        {
            Key.SetActive(true);
        }

        if(Key_Count)
        {
            // end screen
            Debug.Log("Win");
        }
    }
}
