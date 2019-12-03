using DevExpress.Xpo;

namespace E2836.Models
{
    public class MyObject : XPObject
    {
        public MyObject() : base() { }

        public MyObject(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        protected string _Title;
        public string Title
        {
            get { return _Title; }
            set { SetPropertyValue<string>("Title", ref _Title, value); }
        }
    }
}