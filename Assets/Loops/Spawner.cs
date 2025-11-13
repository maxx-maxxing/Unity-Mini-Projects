using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [FormerlySerializedAs("_tree")] [SerializeField]
    private GameObject tree;
    
    [SerializeField]
    private int numberOfTrees;
    void Start()
    {
        PrintTrees(numberOfTrees);
    }

    
    
    void PrintTrees(int numberOfTrees)
    {
        for (int i = 0; i < numberOfTrees; i++)
        {
            if (i == 0)
            {
                Instantiate(tree, Vector3.zero, Quaternion.identity);
            }
            else
            {
                Instantiate(tree, new Vector3((i * 1.5f), 0, 0), Quaternion.identity);
            }
        }
    }
}
