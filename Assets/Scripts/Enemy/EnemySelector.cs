using UnityEngine;

public class EnemySelector : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private GameObject selectorSprite;

    private EnemyBrain enemyBrain;

    private void Awake()
    {
        enemyBrain = GetComponent<EnemyBrain>();
    }
    private void EnemySelectedCallBack(EnemyBrain enemySelected)
    {
        if(enemySelected == enemyBrain)
        {
            selectorSprite.SetActive(true);
        }
        else
        {
            selectorSprite.SetActive(false);
        }
    }

    public void NoSelectionCallBack()
    {
        selectorSprite.SetActive(false);
    }
    private void OnEnable()
    {
        SelectionManager.OnEnemySelectedEvent += EnemySelectedCallBack;
        SelectionManager.OnNoSelectionEvent += NoSelectionCallBack;
    }

    private void OnDisable()
    {
        SelectionManager.OnEnemySelectedEvent -= EnemySelectedCallBack;
        SelectionManager.OnNoSelectionEvent -= NoSelectionCallBack;

    }
}

