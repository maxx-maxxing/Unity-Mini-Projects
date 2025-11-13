using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject tree;
    
    [SerializeField]
    private int numberOfTrees;

    [SerializeField] private float spawnOffset;
    
    
    void Start()
    {
        PrintTrees(numberOfTrees);
    }

    
    
    void PrintTrees(int trees)
    {
        for (int i = 0; i < trees; i++)
        {
            float x = spawnOffset * i;
            Instantiate(tree, new Vector3(x, 0, 0), Quaternion.identity);
        }
    }
}
