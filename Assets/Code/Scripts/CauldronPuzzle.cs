using UnityEngine;
using System.Collections.Generic;

public class CauldronPuzzle : MonoBehaviour
{
    public GameObject[] correctSequence; // Array to store the correct sequence of game objects
    // public GameObject key; // Key to spawn when puzzle is solved

    private int currentIndex = 0; // Index to track the current game object in the sequence
    private Dictionary<GameObject, Vector3> originalPositions = new Dictionary<GameObject, Vector3>(); // Dictionary to store original positions

    private void Start()
    {
        // Save the original positions of all game objects
        foreach (GameObject obj in correctSequence)
        {
            originalPositions.Add(obj, obj.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject droppedObject = other.gameObject;

        // Check if the dropped object is the correct one in the sequence
        if (droppedObject == correctSequence[currentIndex])
        {
            // Move to the next object in the sequence
            currentIndex++;

            // Check if all objects have been added in the correct order
            if (currentIndex >= correctSequence.Length)
            {
                // Puzzle solved, spawn the key
                // SpawnKey();
            }
        }
        else
        {
            // Incorrect object added, reset its position
            ResetObjectPosition(droppedObject);
        }
    }

    private void ResetObjectPosition(GameObject obj)
    {
        // Reset the object's position to its original position
        if (originalPositions.ContainsKey(obj))
        {
            obj.transform.position = originalPositions[obj];
        }
    }

    // private void SpawnKey()
    // {
    //     // Spawn the key game object
    //     Instantiate(key, transform.position, Quaternion.identity);
    // }
}
