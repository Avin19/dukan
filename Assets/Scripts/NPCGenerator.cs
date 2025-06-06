using UnityEngine;
using UnityEngine.UI;


public enum Gender
{
    Male,
    Female
}
public class NPCGenerator : MonoBehaviour
{
    [SerializeField] private Transform hair;
    [SerializeField] private Transform eyesBrow;

    [SerializeField] private Transform nose;
    [SerializeField] private Transform mouth;
    [SerializeField] private Transform cloth;
    [SerializeField] private Gender gender;


    [SerializeField] private NPCSO npcSOdetails;
    [SerializeField] private int index;

    private void Start()
    {
        Change();
    }
    private void Change()
    {
        eyesBrow.GetComponent<SpriteRenderer>().sprite = npcSOdetails.EyeBrows[RandomNumber(npcSOdetails.EyeBrows.Length)];
        nose.GetComponent<SpriteRenderer>().sprite = npcSOdetails.Noses[RandomNumber(npcSOdetails.Noses.Length)];
        mouth.GetComponent<SpriteRenderer>().sprite = npcSOdetails.Mouths[RandomNumber(npcSOdetails.Mouths.Length)];
        if (gender == Gender.Male)
        {

            hair.GetComponent<SpriteRenderer>().sprite = npcSOdetails.MaleHair[RandomNumber(npcSOdetails.MaleHair.Length)];
            hair.GetComponent<SpriteRenderer>().color = npcSOdetails.hairColor[RandomNumber(npcSOdetails.hairColor.Length)];
            cloth.GetComponent<SpriteRenderer>().sprite = npcSOdetails.MaleCloth[RandomNumber(npcSOdetails.MaleCloth.Length)];

        }
        else
        {

            hair.GetComponent<SpriteRenderer>().sprite = npcSOdetails.FemaleHair[RandomNumber(npcSOdetails.FemaleHair.Length)];

        }


    }
    private int RandomNumber(int length)
    {
        return Random.Range(0, length);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Change();
        }
    }

}


