namespace MVPDemo.BaseFactory
{
    public class PresenterBase<IView>
    {
        public IView View { get; private set; }

        public PresenterBase(IView view)
        {
            this.View = view;
            this.OnViewSet();
        }
        protected virtual void OnViewSet() { }
    }
}
