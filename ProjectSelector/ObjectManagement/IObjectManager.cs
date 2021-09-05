namespace ProjectSelector.ObjectManagement
{
    using System.Collections.Generic;

    public interface IObjectManager
    {
        public List<IObject> Objects { get; set; }

        void Update();

        void Draw();

        void AddObject(IObject objectInstance);

        void RemoveObject(IObject objectInstance);
    }
}