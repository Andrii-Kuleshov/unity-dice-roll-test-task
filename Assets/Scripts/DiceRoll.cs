using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    int strengthModifier = 3;
    int questDifficulty = 12;

    void Start()
    {
        int diceRoll = Random.Range(1, 21);
        int totalResult = diceRoll + strengthModifier;
        
        Debug.Log("Dice Roll: " + diceRoll);
        Debug.Log("Modifier: " + strengthModifier);
        Debug.Log("Total Result: " + totalResult);
        Debug.Log("Quest Difficulty: " + questDifficulty);

        if (totalResult > questDifficulty)
        {
            Debug.Log("Success!");
        }
        else
        {
            Debug.Log("Failure!");
        }
    }
}