﻿namespace MVPDemo
{
    public class Presenter<IView>
    {
        public IView View { get; private set; }

        public Presenter(IView view)
        {
            this.View = view;
            this.OnViewSet();
        }
        protected virtual void OnViewSet()
        { }
    }
}
