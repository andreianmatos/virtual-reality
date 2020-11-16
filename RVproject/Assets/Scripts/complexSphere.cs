
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class complexSphere : MonoBehaviour
{
    XRGrabInteractable m_GrabInteractable;
    MeshRenderer m_MeshRenderer;

    static Color s_UnityMagenta = new Color(0.929f, 0.094f, 0.278f, 0.5f);
    static Color s_UnityCyan = new Color(0.019f, 0.733f, 0.827f, 0.5f);
    //static Color originalColor;

    bool m_Held;

    protected void OnEnable()
    {
        m_GrabInteractable = GetComponent<XRGrabInteractable>();
        m_MeshRenderer = GetComponent<MeshRenderer>();
        //originalColor = m_MeshRenderer.material.color;
        //originalColor.a = 0.8f;
        //m_MeshRenderer.material.color = originalColor;

        m_GrabInteractable.onFirstHoverEnter.AddListener(OnFirstHoverEntered);
        m_GrabInteractable.onLastHoverExit.AddListener(OnLastHoverExited);
        m_GrabInteractable.onSelectEnter.AddListener(OnSelectEntered);
        m_GrabInteractable.onSelectExit.AddListener(OnSelectExited);

    }


    protected void OnDisable()
    {
        m_GrabInteractable.onHoverEnter.AddListener(OnFirstHoverEntered);
        m_GrabInteractable.onLastHoverExit.AddListener(OnLastHoverExited);
        m_GrabInteractable.onSelectEnter.AddListener(OnSelectEntered);
        m_GrabInteractable.onSelectExit.AddListener(OnSelectExited);
    }

    protected virtual void OnSelectEntered(XRBaseInteractor interactor)
    {
        Destroy(gameObject);
    }

    protected virtual void OnSelectExited(XRBaseInteractor interactor)
    {
        m_MeshRenderer.material.color = Color.white;
        m_Held = false;
    }

    protected virtual void OnLastHoverExited(XRBaseInteractor interactor)
    {
        if (!m_Held)
        {
            m_MeshRenderer.material.color = s_UnityMagenta;
        }
    }

    protected virtual void OnFirstHoverEntered(XRBaseInteractor interactor)
    {
        if (!m_Held)
        {
            m_MeshRenderer.material.color = s_UnityCyan;
        }
    }
}

