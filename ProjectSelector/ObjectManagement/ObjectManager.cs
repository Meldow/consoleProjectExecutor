namespace ProjectSelector.ObjectManagement
{
    using System.Collections.Generic;

    public class ObjectManager : IObjectManager
    {
        public List<IObject> Objects { get; set; }

        public void Update()
        {
            foreach (var o in Objects)
            {
                o.Update();
            }
        }

        public void Draw()
        {
            foreach (var o in Objects)
            {
                o.Draw();
            }
        }

        public void AddObject(IObject objectInstance)
        {
            this.Objects.Add(objectInstance);
        }

        public void RemoveObject(IObject objectInstance)
        {
            this.Objects.Remove(objectInstance);
        }
    }
}