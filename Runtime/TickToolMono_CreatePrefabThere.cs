using UnityEngine;

namespace Eloi.Tick
{
    public class TickToolMono_CreatePrefabThere : MonoBehaviour
    {
        public GameObject m_prefabToCreate;
        public Transform m_parentTransform;
        public Transform m_whereToCreateIt;
        public GameObject m_created;
        public float m_destroyTime = 5f;
        public void CreatePrefab()
        {
            
            if (m_prefabToCreate == null)
                return;
            if (m_whereToCreateIt == null)
                return;

            m_created = Instantiate(m_prefabToCreate, m_parentTransform);
            if (m_whereToCreateIt != null)
            {
                m_created.transform.position = m_whereToCreateIt.position;
                m_created.transform.rotation = m_whereToCreateIt.rotation;
                m_created.transform.localScale = m_whereToCreateIt.localScale;
            }

            m_created.SetActive(true);
           
            
                if (Application.isPlaying)
                    Destroy(m_created, m_destroyTime);
                else
                    DestroyImmediate(m_created, true);
            


        }
    }
}
