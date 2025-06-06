using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NPCSO", menuName = "NPCSO", order = 0)]
public class NPCSO : ScriptableObject
{
    public Sprite[] MaleHair;
    public Sprite[] FemaleHair;
    public Sprite[] EyeBrows;
    public Sprite[] Noses;
    public Sprite[] Mouths;
    public Sprite[] MaleCloth;

    public Color[] skinColor;
    public Color[] hairColor;


}

