using System;
using UnityEditor;
using UnityEngine;

namespace Febucci.HierarchyData
{
    public class HierarchyData : ScriptableObject
    {
        public bool enabled = true;
        
        #region Icons Data

        [System.Serializable]
        public class IconsData
        {
            public bool enabled = true;
            [System.Serializable]
            public struct HierarchyElement
            {
                [SerializeField] public Texture2D iconToDraw;
                [SerializeField] public MonoScript[] targetClasses;
            }
            
            public bool aligned = false;
            public HierarchyElement[] pairs = new HierarchyElement[0];
        }
        
        public IconsData icons;
        
        #endregion

        #region PrefabsData

        [System.Serializable]
        public class PrefabsData
        {
            public bool enabled;

            [System.Serializable]
            public class Prefab
            {
                public GameObject gameObject;
                public Color color;
            }

            public Prefab[] prefabs = new Prefab[0];
        }

        public PrefabsData prefabsData;
        

        #endregion
        
        #region Alternating Lines

        [System.Serializable]
        public class AlternatingBGData
        {
            public bool enabled = true;
            public Color color = new Color(0,0,0, .08f);
        }

        public AlternatingBGData alternatingBackground;
        
        #endregion

        #region SeparatorData

        [System.Serializable]
        public class SeparatorData
        {
            public bool enabled = true;
            public string startString = ">";
            public Color color = new Color(0, 1,1, .15f);
        }
        
        public SeparatorData separator;

        #endregion

        #region Tree

        [System.Serializable]
        public class TreeData
        {
            public bool enabled = true;
            public bool drawOverlayOnColoredPrefabs = true;
            [Range(0,3)] public float dividerHeigth = 1;
            public Color baseLevelColor = Color.gray;

            [System.Serializable]
            public class BranchGroup
            {
                public Color overlayColor;
                public Color[] colors = new Color[0];
            }

            [Space]
            public BranchGroup[] branches = new[]
            {
                new BranchGroup()
                {
                    overlayColor =  new Color(1f, 0.44f, 0.97f, .04f),
                    colors = new []
                    {
                        new Color(1f, 0.44f, 0.97f), 
                        new Color(0.56f, 0.44f, 1f), 
                        new Color(0.44f, 0.71f, 1f), 
                        new Color(0.19f, 0.53f, 0.78f)
                    }
                },
                
                new BranchGroup()
                {
                    overlayColor =  new Color(0.93f, 1f, 0.42f, .04f), 
                    colors = new []
                    {
                        new Color(0.93f, 1f, 0.42f), 
                        new Color(1f, 0.75f, 0.42f), 
                        new Color(1f, 0.46f, 0.31f), 
                        new Color(1f, 0.35f, 0.34f)
                    }
                }
            };
        }

        public TreeData tree;
        

        #endregion

        private void OnValidate()
        {
            HierarchyDrawer.Initialize();
        }
    }
}