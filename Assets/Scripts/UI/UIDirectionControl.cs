using UnityEngine;

public class UIDirectionControl : MonoBehaviour
{
    public bool m_UseRelativeRotation = true;

    private Quaternion m_RelativeRotation;

    private void Start()
    {
        m_RelativeRotation = transform.parent.localRotation; //Find the local rotation of the canvas
    }

    private void Update()
    {
        if (m_UseRelativeRotation)
            transform.rotation = m_RelativeRotation; //To keep the rotation static
    }
}
