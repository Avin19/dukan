using UnityEngine;
using UnityEngine.UI;

public class ChipController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform _position1;
    [SerializeField] private Transform _position2;
    [SerializeField] private Transform _position3;
    [SerializeField] private Transform _position4;
    [SerializeField] private Transform _position5;

    [SerializeField] private ChipSO chipSO;

    [SerializeField] private GameObject chipsPerfabs;
    void Start()
    {
        for (int i = 0; i < chipSO.bluelays; i++)
        {
            AddChipsData(chipSO.bluelayPic, _position1, i);
        }
        for (int i = 0; i < chipSO.greenlays; i++)
        {
            AddChipsData(chipSO.greenlaysPic, _position2, i);
        }
        for (int i = 0; i < chipSO.redlays; i++)
        {
            AddChipsData(chipSO.redlaysPic, _position3, i);
        }
        for (int i = 0; i < chipSO.yellowlays; i++)
        {
            AddChipsData(chipSO.yellowlaysPic, _position4, i);
        }
        for (int i = 0; i < chipSO.kukree; i++)
        {
            AddChipsData(chipSO.kukreePic, _position5, i);
        }
    }

    public void AddChipsData(Sprite _sprite, Transform _position, int i)
    {
        GameObject item = Instantiate(chipsPerfabs, new Vector3(_position.position.x, i * (-1.2f) + _position.position.y, 0f), Quaternion.identity, _position);
        item.GetComponent<SpriteRenderer>().sprite = _sprite;
    }


}
