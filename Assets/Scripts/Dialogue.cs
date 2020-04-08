using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue 1", menuName = "Dialogue", order = 1)]

public class Dialogue : ScriptableObject
{
	public string[] CharactersList;
	//DialogueElement.Characters;

	public List<DialogueElement> DialogueItems;
}

