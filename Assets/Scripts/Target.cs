using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Artefact _artefact;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(_artefact.gameObject);
            enemy.transform.SetParent(this.transform);
        }
    }
}
