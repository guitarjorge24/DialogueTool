using UnityEngine;

[System.Serializable] //needed to make ScriptableObject out of this class
public class DialogueElement
{
	public enum Characters { CharacterA, CharacterB};
	public enum AvatarPos { left, right };

	[Header("CHARACTER")]
	public Characters Character;
	public AvatarPos CharacterPosition;
	public Texture2D CharacterPic;

	[Header("DIALOGUE")]
	[Tooltip("What the character is saying")]
	public string DialogueText;
	public GUIStyle DialogueTextStyle;
	[Tooltip("How many letters per second")]
	public float TextPlayBackSpeed;

	public AudioClip PlayBackSoundFile;
}