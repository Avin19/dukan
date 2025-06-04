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
    [SerializeField] private Gender gender;


    [SerializeField] private NPCSO npcSOdetails;

    private void Start()
    {
        Change();
    }
    private void Change()
    {
        if (gender == Gender.Male)
        {
            int index = Random.Range(0, npcSOdetails.MaleHair.Length - 1);
            hair.GetComponent<SpriteRenderer>().sprite = npcSOdetails.MaleHair[index];
            nose.GetComponent<SpriteRenderer>().sprite = npcSOdetails.Noses[index];
            mouth.GetComponent<SpriteRenderer>().sprite = npcSOdetails.Mouths[index];
        }
        else
        {
            int index = Random.Range(0, npcSOdetails.FemaleHair.Length - 1);
            hair.GetComponent<SpriteRenderer>().sprite = npcSOdetails.FemaleHair[index];
            nose.GetComponent<SpriteRenderer>().sprite = npcSOdetails.Noses[index];
            mouth.GetComponent<SpriteRenderer>().sprite = npcSOdetails.Mouths[index];
        }


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Change();
        }
    }

}


