using UnityEngine;

public class Toy : MonoBehaviour
{
    [SerializeField] private GameObject[] toyParts;

    public void DisablePart(int index)
    {
        toyParts[index].SetActive(false);
    }

    public void EnableToy()
    {
        for (int i = 0; i < toyParts.Length; i++)
        {
            toyParts[i].SetActive(true);
        }
    }

}
